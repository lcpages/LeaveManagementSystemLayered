using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveAllocationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LeaveTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<string>(type: "TEXT", nullable: false),
                    PeriodId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e12b6efd-da0e-49de-aa9f-d3c18275794a", "AQAAAAIAAYagAAAAEHURSwd9bylsuIIXPAaLgMTKgiZ/z0eY1lmw7klXqev8+Kc14kIwvQJ/SDH/dpurgA==", "4744218f-415c-4a79-8d29-b50d76365f22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413ac0f8-c704-4345-bb80-8d68788e5167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de23ebfb-755e-4888-aa49-36e18852de75", "AQAAAAIAAYagAAAAEFr7VBuKy8ShqyPgCyVhtklZ4iuWI4L4Xlarkl7Z0wMi9rTyPdOJLcVE2xyhJvQE3Q==", "5659a060-6359-42b5-891c-26d66e81215b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8c17cdf-eee3-4fe1-b4da-5c1fdb7fd644", "AQAAAAIAAYagAAAAEPuopYlu3D1zKp2S2eEr8l1dKnPDQEIjgo22EhHtGJjJy49vwcsLOa3+/GrrJSJIOw==", "0ba41455-6b23-4418-a6bf-31aed347e8fa" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_EmployeeId",
                table: "LeaveAllocations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_PeriodId",
                table: "LeaveAllocations",
                column: "PeriodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0db65bdd-5070-44c0-a3e5-23eac7b3aa9e", "AQAAAAIAAYagAAAAELsAAKtEj7sx5qLz4W4KyWfNu35zQLEgwzMyng9PempvSEH2z8XM4H6TFkMX6ygpPw==", "1da6d051-937e-4c42-9050-efd885c22f30" });

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
        }
    }
}
