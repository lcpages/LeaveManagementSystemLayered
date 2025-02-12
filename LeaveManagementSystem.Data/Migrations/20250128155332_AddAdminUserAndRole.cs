using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUserAndRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46ef8847-a5cf-499b-9d4a-94f4fadd8152", "0065b14e-2443-4a02-84e1-965396006774" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006774");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413ac0f8-c704-4345-bb80-8d68788e5167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4301a36-8b65-4d56-9028-7a38a6041644", "AQAAAAIAAYagAAAAEMQpJ56WGCAAc/bUk/1rF5bVO8aZfuK/BjbiTLa89FIi/yOmeIxjCCEzihEoaJNY7w==", "dd70231b-9d78-46ed-8782-9dc0ad495092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f9acb7-5131-4699-92da-1031c39b96b2", "AQAAAAIAAYagAAAAEM4JSMHT4i1b+d8MSvXxpd7JZlzKjoEQnwJ2B/YMA8Cccd+10zqK83x0k2ZDDbqOag==", "04aff9e3-aa25-430f-b8ea-a4febbb9fc37" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0065b14e-2443-4a02-84e1-965396006771", 0, "0db65bdd-5070-44c0-a3e5-23eac7b3aa9e", new DateOnly(2000, 1, 1), "admin@locahost.com", true, "Administrator", "Administrator", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELsAAKtEj7sx5qLz4W4KyWfNu35zQLEgwzMyng9PempvSEH2z8XM4H6TFkMX6ygpPw==", null, false, "1da6d051-937e-4c42-9050-efd885c22f30", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46ef8847-a5cf-499b-9d4a-94f4fadd8152", "0065b14e-2443-4a02-84e1-965396006771" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46ef8847-a5cf-499b-9d4a-94f4fadd8152", "0065b14e-2443-4a02-84e1-965396006771" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006771");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413ac0f8-c704-4345-bb80-8d68788e5167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab30fff8-1abf-4aee-8d58-4528ed079889", "AQAAAAIAAYagAAAAEC+rNwsLfgbbNnSRLvowAInQ7HLxK/A8oGJEBrdo18xz87i3QImpc3QKHklK0kBNMg==", "abcbf04e-e683-4686-983d-a519219530c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c3ecac1-f071-4978-9019-e48f140e0c2e", "AQAAAAIAAYagAAAAEMFMcTNcXu8hBF/rkWW2/Z+SNADNpjVV7b3qQfqTIfifF8ZT29nrqrBY3DoaBSsUxA==", "ed66fe63-5a13-4124-ac6c-10b29ac22050" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0065b14e-2443-4a02-84e1-965396006774", 0, "0889b365-9267-49f7-a390-b0ce7015a416", new DateOnly(2000, 1, 1), "admin@locahost.com", true, "Administrator", "Administrator", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEACVa9g0/Hxj+FKh4ZzsRikjlnSay6dhwQAdCroXLac2ww8ttZrw5YCzxs2bi7ELcg==", null, false, "583fdc6e-0ad7-4a85-8506-ed420dc72e2a", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46ef8847-a5cf-499b-9d4a-94f4fadd8152", "0065b14e-2443-4a02-84e1-965396006774" });
        }
    }
}
