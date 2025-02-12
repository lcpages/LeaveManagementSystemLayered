using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

using LeaveManagementSystem.Application.Models.LeaveAllocations;
using LeaveManagementSystem.Application.Services.Periods;
using LeaveManagementSystem.Application.Services.Users;
using LeaveManagementSystem.Data;

namespace LeaveManagementSystem.Application.Services.LeaveAllocations;

public class LeaveAllocationsService : ILeaveAllocationsService
{
    private readonly ApplicationDbContext _context; 
    private readonly IUsersService _usersService;
    private readonly IMapper _mapper;
    private readonly IPeriodsService _periodsService;

    public LeaveAllocationsService(
        ApplicationDbContext context,
        IMapper mapper,
        IPeriodsService periodsService,
        IUsersService usersService
    )
    {
        _context = context;
        _mapper = mapper;
        _periodsService = periodsService;
        _usersService = usersService;
    }
    
    public async Task AllocateLeave(string employeeId)
    {
        //Get All the LeaveTypes
        var LeaveTypes = await _context.LeaveTypes
            .Where(q => !q.LeaveAllocations.Any(x => x.EmployeeId == employeeId))
            .ToListAsync();

        //Get the current period based on the year
        var period = await _periodsService.GetCurrentPeriod();
        var monthsRemaining = period.EndDate.Month - DateTime.Now.Month;

        //calculate leave based on number of months left in the period
        foreach(var leaveType in LeaveTypes)
        {
            var accuralRate = decimal.Divide(leaveType.NumberOfDays, 12);
            var leaveAllocation = new LeaveAllocation
            {
                EmployeeId = employeeId,
                LeaveTypeId = leaveType.Id,
                PeriodId = period.Id,
                Days = (int) Math.Ceiling(accuralRate * monthsRemaining),
            };

            _context.Add(leaveAllocation);
        }
        
        await _context.SaveChangesAsync();
    }

    public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string? userId)
    {
        var user = string.IsNullOrEmpty(userId) ? await _usersService.GetLoggedInUser() : await _usersService.GetUserById(userId);

        var allocations = await GetAllocations(user.Id);
        var allocationVmList = _mapper.Map<List<LeaveAllocation>,List<LeaveAllocationVM>>(allocations);

        var leaveTypesCount = await _context.LeaveTypes.CountAsync();

        var employeeVM = new EmployeeAllocationVM
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            DateOfBirth = user.DateOfBirth,
            LeaveAllocations = allocationVmList,
            IsCompletedAllocation = leaveTypesCount == allocations.Count
        };
        
        return employeeVM;
    }

    public async Task<List<EmployeeListVM>> GetEmployees()
    {
        var users = await _usersService.GetEmployees();
        var employees = _mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(users.ToList());

        return employees;
    }

    public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int? allocationId)
    {
        var allocation = await _context.LeaveAllocations
            .Include(q => q.LeaveType)
            .Include(q => q.Employee)
            .FirstOrDefaultAsync(q => q.Id == allocationId);
        
        var model = _mapper.Map<LeaveAllocationEditVM>(allocation);

        return model;
    }

    public async Task EditAllocation(LeaveAllocationEditVM allocationEditVm)
    {
        /* var leaveAllocation = await GetEmployeeAllocation(allocationEditVm.Id);
        if(leaveAllocation == null)
        {
            throw new Exception("Leave allocation record does not exists");
        }
        leaveAllocation.Days = allocationEditVm.Days;#
        */
        //option 1
        //_context.Update(leaveAllocation);
        //option 2 - More precise
        //_context.Entry(leaveAllocation).State = EntityState.Modified;
        //Require in both cases
        //_context.SaveChangesAsync();

        //best option

        await _context.LeaveAllocations
            .Where(e=>e.Id == allocationEditVm.Id)
            .ExecuteUpdateAsync(s=> s.SetProperty(e=>e.Days, allocationEditVm.Days));
    }
    public async Task<LeaveAllocation> GetCurrentAllocation(int leaveTypeId, string employeeId)
    {
        var period = await _periodsService.GetCurrentPeriod();
        var allocation = await _context.LeaveAllocations
            .FirstOrDefaultAsync(q => q.EmployeeId == employeeId 
                && q.LeaveTypeId == leaveTypeId
                && q.PeriodId == period.Id);

        return allocation;
    }
    
    private async Task<List<LeaveAllocation>> GetAllocations(string? userId)
    {
        var currentDate = DateTime.Now;
        //var period = await _context.Periods.SingleAsync(q => q.EndDate.Year == currentDate.Year);
        var period = await _periodsService.GetCurrentPeriod();

        var leaveAllocations = await _context.LeaveAllocations
            .Include(q=>q.LeaveType)
            .Include(q=>q.Employee)
            .Include(q=>q.Period)
            .Where(q=>q.EmployeeId == userId && q.Period.Id == period.Id)
            .ToListAsync();

        return leaveAllocations;
    }

    private async Task<bool> AllocationExists(string userId, int periodId, int leaveTypeId)
    {
        var exists = await _context.LeaveAllocations.AnyAsync(q => q.EmployeeId == userId && q.PeriodId == periodId && q.LeaveTypeId == leaveTypeId);

        return exists;
    }
}
