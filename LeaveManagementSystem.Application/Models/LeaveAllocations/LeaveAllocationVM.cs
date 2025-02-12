using System;
using System.ComponentModel.DataAnnotations;
using LeaveManagementSystem.Application.Models.LeaveTypes;
using LeaveManagementSystem.Application.Models.Periods;

namespace LeaveManagementSystem.Application.Models.LeaveAllocations;

public class LeaveAllocationVM
{
    public int Id { get; set; }

    [Display(Name = "Number of Days")]
    public int Days { get; set; }

    [Display(Name = "Allocation Period")]
    public PeriodVM Period { get; set; } = new PeriodVM();

    public LeaveTypeReadOnlyVM LeaveType { get; set; } = new LeaveTypeReadOnlyVM();

}