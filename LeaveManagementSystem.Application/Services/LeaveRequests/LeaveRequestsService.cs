using System;
using LeaveManagementSystem.Application.Models.LeaveRequests;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Application.Models.LeaveAllocations;
using LeaveManagementSystem.Application.Services.LeaveAllocations;
using LeaveManagementSystem.Application.Services.Users;
using LeaveManagementSystem.Data;

namespace LeaveManagementSystem.Application.Services.LeaveRequests;

public class LeaveRequestsService : ILeaveRequestsService
{
    private readonly IMapper _mapper; 
    private readonly IUsersService _usersService;
    private readonly ApplicationDbContext _context;
    private readonly ILeaveAllocationsService _leaveAllocationsService;

    public LeaveRequestsService(IMapper mapper,
     ApplicationDbContext context,
     ILeaveAllocationsService leaveAllocationsService,
     IUsersService usersService)
    {
        _mapper = mapper;
        _usersService = usersService;
        _context = context;
        _leaveAllocationsService = leaveAllocationsService;
    } 
    public async Task CancelLeaveRequest(int leaveRequestId)
    {
        var leaveRequest = await _context.LeaveRequests.FindAsync(leaveRequestId);
        leaveRequest.LeaveRequestStatusId = (int)LeaveRequestStatusEnum.Canceled;

        await UpdateAllocationDays(leaveRequest, false);

        await _context.SaveChangesAsync();
    }   

    public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
    {
        var leaveRequest = _mapper.Map<LeaveRequest>(model); 
        var user = await _usersService.GetLoggedInUser();
        leaveRequest.EmployeeId = user.Id; 

        leaveRequest.LeaveRequestStatusId = (int) LeaveRequestStatusEnum.Pending; 

        _context.LeaveRequests.Add(leaveRequest);

        await UpdateAllocationDays(leaveRequest, true);

        await _context.SaveChangesAsync();
    }

    public async Task<EmployeeLeaveRequestListVM> AdminGetAllLeaveRequests()
    {
        
        var leaveRequests = await _context.LeaveRequests
            .Include(q => q.LeaveType)
            .ToListAsync();

        var approvedLeaveRequests = leaveRequests.Count(q => q.LeaveRequestStatusId == (int)LeaveRequestStatusEnum.Approved);
        var pendingLeaveRequests = leaveRequests.Count(q => q.LeaveRequestStatusId == (int)LeaveRequestStatusEnum.Pending);
        var declinedLeaveRequests = leaveRequests.Count(q => q.LeaveRequestStatusId == (int)LeaveRequestStatusEnum.Declined);

        var leaveRequestModels = leaveRequests.Select(q => new LeaveRequestReadOnlyVM
        {
            Id = q.Id,
            StartDate = q.StartDate,
            EndDate = q.EndDate,
            LeaveType = q.LeaveType.Name,
            Status =(LeaveRequestStatusEnum) q.LeaveRequestStatusId, 
            NumberOfDays = q.EndDate.DayNumber - q.StartDate.DayNumber
        }).ToList();

        var model = new EmployeeLeaveRequestListVM
        {
            ApprovedRequests = approvedLeaveRequests,
            PendingRequests = pendingLeaveRequests,
            DeclinedRequests = declinedLeaveRequests,
            TotalRequests = leaveRequests.Count,
            LeaveRequests = leaveRequestModels
        };

        return model;

    }

    public async Task<List<LeaveRequestReadOnlyVM>> GetEmployeeLeaveRequests()
    {
        var user = await _usersService.GetLoggedInUser();
        var leaveRequests = await _context.LeaveRequests
            .Include(q => q.LeaveType)
            .Where(q => q.EmployeeId == user.Id)
            .ToListAsync();

        var model = leaveRequests.Select(q => new LeaveRequestReadOnlyVM
        {
            Id = q.Id,
            StartDate = q.StartDate,
            EndDate = q.EndDate,
            LeaveType = q.LeaveType.Name,
            Status =(LeaveRequestStatusEnum) q.LeaveRequestStatusId, 
            NumberOfDays = q.EndDate.DayNumber - q.StartDate.DayNumber
        }).ToList();

        return model; 

    }
    public async Task ReviewLeaveRequest(int LeaveRequestId, bool approved)
    {
        var user = await _usersService.GetLoggedInUser();
        var leaveRequest = await _context.LeaveRequests.FindAsync(LeaveRequestId);
        leaveRequest.LeaveRequestStatusId = approved ? (int)LeaveRequestStatusEnum.Approved : (int)LeaveRequestStatusEnum.Declined;

        //Get the current period based on the year
        var currentDate = DateTime.Now;
        var period = await _context.Periods.SingleAsync(q => q.EndDate.Year == currentDate.Year);

        leaveRequest.ReviewerId = user.Id;

        if(!approved)
        {
            
            await UpdateAllocationDays(leaveRequest, false);

        }
        await _context.SaveChangesAsync();
    }

    public async Task<bool> RequestDatesExceedAllocation(LeaveRequestCreateVM model)
    {
        //Get the current period based on the year
        var currentDate = DateTime.Now;
        var period = await _context.Periods.SingleAsync(q => q.EndDate.Year == currentDate.Year);
        var user = await _usersService.GetLoggedInUser();
        var numberOfDays = model.EndDate.DayNumber - model.StartDate.DayNumber; 
        var allocationToDeduct = await _context.LeaveAllocations
            .FirstAsync(q => q.LeaveTypeId == model.LeaveTypeId 
            && q.EmployeeId == user.Id
            && q.PeriodId == period.Id);

        return allocationToDeduct.Days < numberOfDays;
    }

    public async Task<ReviewLeaveRequestVM> GetLeaveRequestToReview(int id)
    {
        var leaveRequest = await _context.LeaveRequests
            .Include(q => q.LeaveType)
            .FirstOrDefaultAsync(q => q.Id == id);

            var user = await _usersService.GetUserById(leaveRequest.EmployeeId);

            var model = new ReviewLeaveRequestVM
            {
                Id = leaveRequest.Id,
                StartDate = leaveRequest.StartDate,
                EndDate = leaveRequest.EndDate,
                LeaveType = leaveRequest.LeaveType.Name,
                Status = (LeaveRequestStatusEnum)leaveRequest.LeaveRequestStatusId,
                NumberOfDays = leaveRequest.EndDate.DayNumber - leaveRequest.StartDate.DayNumber,
                RequestComments = leaveRequest.RequestComments,
                Employee = new EmployeeListVM
                {
                    Id = leaveRequest.Employee.Id,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                }
            };

        return model;
    }

    private async Task UpdateAllocationDays(LeaveRequest leaveRequest, bool deductDays)
    {
        var allocation = await _leaveAllocationsService.GetCurrentAllocation( leaveRequest.LeaveTypeId,leaveRequest.EmployeeId);
        var numberOfDays = CalculateDays(leaveRequest.StartDate, leaveRequest.EndDate);

        if(deductDays)
        {
            allocation.Days -= numberOfDays;
        }
        else
        {
            allocation.Days += numberOfDays;
        }
        //Extra, might be uneccessary
        _context.Entry(allocation).State = EntityState.Modified;
    }

    private int CalculateDays(DateOnly startDate, DateOnly endDate)
    {
        return endDate.DayNumber - startDate.DayNumber;
    }
}
