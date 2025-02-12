using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Data.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();

        builder.HasData(
            new ApplicationUser
            {
                Id = "0065b14e-2443-4a02-84e1-965396006771",
                Email = "admin@locahost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Administrator",
                LastName = "Administrator",
                DateOfBirth = new DateOnly(2000, 01, 01)
            },
            new ApplicationUser
            {
                Id = "413ac0f8-c704-4345-bb80-8d68788e5167",
                Email = "employee@locahost.com",
                NormalizedEmail = "EMPLOYEE@LOCALHOST.COM",
                NormalizedUserName = "EMPLOYEE@LOCALHOST.COM",
                UserName = "employee@localhost.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Employee",
                LastName = "Employee",
                DateOfBirth = new DateOnly(2000, 01, 01)
            },
            new ApplicationUser
            {
                Id = "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba",
                Email = "supervisor@locahost.com",
                NormalizedEmail = "SUPERVISOR@LOCALHOST.COM",
                NormalizedUserName = "SUPERVISOR@LOCALHOST.COM",
                UserName = "supervisor@localhost.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Supervisor",
                LastName = "Supervisor",
                DateOfBirth = new DateOnly(2000, 01, 01)
            }
            );
    }
}
