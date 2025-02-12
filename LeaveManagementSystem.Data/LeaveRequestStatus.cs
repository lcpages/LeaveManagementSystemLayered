using System;
using System.ComponentModel.DataAnnotations;
using LeaveManagementSystem.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Data;

public class LeaveRequestStatus : BaseEntity
{
    [StringLength(50)]
    public required string Name { get; set; }

}
