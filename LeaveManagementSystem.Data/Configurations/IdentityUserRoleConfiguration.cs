using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Data.Configurations;

public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {

        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "46ef8847-a5cf-499b-9d4a-94f4fadd8152",
                UserId = "0065b14e-2443-4a02-84e1-965396006771"
            },
            new IdentityUserRole<string>
            {
                RoleId = "a0225234-58e7-4a37-8cd8-c0d60e9f97a3",
                UserId = "413ac0f8-c704-4345-bb80-8d68788e5167"
            },
            new IdentityUserRole<string>
            {
                RoleId = "ea7f6d17-83dc-4691-bb24-679e2c757061",
                UserId = "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba"
            });
    }

}
