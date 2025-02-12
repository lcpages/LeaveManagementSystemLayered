using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagementSystem.Application.Models.LeaveRequests;

public class LeaveRequestCreateVM : IValidatableObject
{
    [DisplayName("Start Date")]
    [Required]
    public DateOnly StartDate { get; set; }

    [DisplayName("End Date")]
    [Required]
    public DateOnly EndDate { get; set; }

    [DisplayName("Desired Leave Type")]
    [Required]
    public int LeaveTypeId { get; set; }

    [DisplayName("Additional Information")]
    public string? RequestComments { get; set; }
    public SelectList? LeaveTypes {get; set;}

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (StartDate > EndDate)
        {
            yield return new ValidationResult("Start date must be before end date", new[] { nameof(StartDate), nameof(EndDate) });
        }
    }
}
