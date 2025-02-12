using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Data.Configurations;

public class IndentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole 
            {   Id = "a0225234-58e7-4a37-8cd8-c0d60e9f97a3",
                NormalizedName = "EMPLOYEE",
                Name = "Employee", 
            },
            new IdentityRole 
            {   Id = "ea7f6d17-83dc-4691-bb24-679e2c757061",
                NormalizedName = "SUPERVISOR",
                Name = "Supervisor", 
            }, 
            new IdentityRole 
            {   Id = "46ef8847-a5cf-499b-9d4a-94f4fadd8152",
                NormalizedName = "ADMINISTRATOR",
                Name = "Administrator", 
            } 
        );
    }
}
