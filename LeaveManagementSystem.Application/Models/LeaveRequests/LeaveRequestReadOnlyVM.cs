using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using LeaveManagementSystem.Application.Services;

namespace LeaveManagementSystem.Application.Models.LeaveRequests;

public class LeaveRequestReadOnlyVM
{
    public int Id { get; set; }

    [DisplayName("Start Date")]
    [Required]
    public DateOnly StartDate { get; set; }

    [DisplayName("End Date")]
    [Required]
    public DateOnly EndDate { get; set; }

    [DisplayName("Total Days")]
    public int NumberOfDays { get; set; }

    [DisplayName("Leave Type")]
    public string LeaveType { get; set; } = string.Empty;

    [DisplayName("Status")]
    public LeaveRequestStatusEnum Status { get; set; }

}
