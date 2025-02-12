using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIDUserRolesRolesUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006774",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a11f4c02-0ca0-4e3c-b9f0-bdcad001271b", "AQAAAAIAAYagAAAAEI26s6NcSXwuPXjKEKFJgYdWp3EEfF/T3DsO7aWq3sQ8nJmyy1XNaUZofd0TIyr6bg==", "8626bc1a-bd5b-43f3-8e91-20efd482847c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006774",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4bfb9bb-5e2f-4fb6-8153-4b7486d8c009", "AQAAAAIAAYagAAAAEJFMXror3isKpkxoSXIbb/MjkkxMXYJIHTmLqXrgUmD468q11WvGkJCjfDuml8r/tA==", "c9bd8095-17c4-4ddf-8a51-ae6fe6226a05" });
        }
    }
}
