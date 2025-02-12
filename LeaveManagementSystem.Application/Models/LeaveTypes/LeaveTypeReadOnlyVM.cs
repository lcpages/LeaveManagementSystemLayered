using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Application.Models.LeaveTypes;

public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
{
    public string Name  { get; set; } = string.Empty;
    
    [Display(Name = "Maximum allocation of Days")]
    public int Days { get; set; }
 
}
