using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDBWithRolesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46ef8847-a5cf-499b-9d4a-94f4fadd8152", null, "Administrator", "ADMINISTRATOR" },
                    { "a0225234-58e7-4a37-8cd8-c0d60e9f97a3", null, "Employee", "EMPLOYEE" },
                    { "ea7f6d17-83dc-4691-bb24-679e2c757061", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0065b14e-2443-4a02-84e1-965396006774", 0, "e5e131db-87e0-4309-8bb0-257e8f106ad9", "admin@locahost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFEmDeqf0HMlQZTyxAMRQz5p6ouAeZak7r+z0HoP4Qec1tUy4C/QbI2Oe3x4Phr0Ew==", null, false, "d05562b7-6907-4472-8c94-ccb3c9cd405c", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46ef8847-a5cf-499b-9d4a-94f4fadd8152", "0065b14e-2443-4a02-84e1-965396006774" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0225234-58e7-4a37-8cd8-c0d60e9f97a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea7f6d17-83dc-4691-bb24-679e2c757061");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46ef8847-a5cf-499b-9d4a-94f4fadd8152", "0065b14e-2443-4a02-84e1-965396006774" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46ef8847-a5cf-499b-9d4a-94f4fadd8152");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006774");
        }
    }
}
