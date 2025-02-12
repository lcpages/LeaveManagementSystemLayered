using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeeDUsersRolesAndUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006774",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0889b365-9267-49f7-a390-b0ce7015a416", new DateOnly(2000, 1, 1), "Administrator", "Administrator", "AQAAAAIAAYagAAAAEACVa9g0/Hxj+FKh4ZzsRikjlnSay6dhwQAdCroXLac2ww8ttZrw5YCzxs2bi7ELcg==", "583fdc6e-0ad7-4a85-8506-ed420dc72e2a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "413ac0f8-c704-4345-bb80-8d68788e5167", 0, "ab30fff8-1abf-4aee-8d58-4528ed079889", new DateOnly(2000, 1, 1), "employee@locahost.com", true, "Employee", "Employee", false, null, "EMPLOYEE@LOCALHOST.COM", "EMPLOYEE@LOCALHOST.COM", "AQAAAAIAAYagAAAAEC+rNwsLfgbbNnSRLvowAInQ7HLxK/A8oGJEBrdo18xz87i3QImpc3QKHklK0kBNMg==", null, false, "abcbf04e-e683-4686-983d-a519219530c7", false, "employee@localhost.com" },
                    { "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba", 0, "1c3ecac1-f071-4978-9019-e48f140e0c2e", new DateOnly(2000, 1, 1), "supervisor@locahost.com", true, "Supervisor", "Supervisor", false, null, "SUPERVISOR@LOCALHOST.COM", "SUPERVISOR@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMFMcTNcXu8hBF/rkWW2/Z+SNADNpjVV7b3qQfqTIfifF8ZT29nrqrBY3DoaBSsUxA==", null, false, "ed66fe63-5a13-4124-ac6c-10b29ac22050", false, "supervisor@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a0225234-58e7-4a37-8cd8-c0d60e9f97a3", "413ac0f8-c704-4345-bb80-8d68788e5167" },
                    { "ea7f6d17-83dc-4691-bb24-679e2c757061", "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0225234-58e7-4a37-8cd8-c0d60e9f97a3", "413ac0f8-c704-4345-bb80-8d68788e5167" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea7f6d17-83dc-4691-bb24-679e2c757061", "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413ac0f8-c704-4345-bb80-8d68788e5167");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006774",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a11f4c02-0ca0-4e3c-b9f0-bdcad001271b", new DateOnly(1980, 12, 1), "Admin", "Admin", "AQAAAAIAAYagAAAAEI26s6NcSXwuPXjKEKFJgYdWp3EEfF/T3DsO7aWq3sQ8nJmyy1XNaUZofd0TIyr6bg==", "8626bc1a-bd5b-43f3-8e91-20efd482847c" });
        }
    }
}
