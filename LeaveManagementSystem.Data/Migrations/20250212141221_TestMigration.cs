using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e73afd-1214-4703-90c7-4094cebc8fb8", "AQAAAAIAAYagAAAAEGGbHo6DrpdZsQYUiJst6ounnl282qwjpf75UFSMCItxxDb4Wwv8vE/0UpIuH2dyyA==", "82212b87-43a6-40be-94b3-57bb237a11f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413ac0f8-c704-4345-bb80-8d68788e5167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0937d2-8ae1-442d-ad7f-6c5d10d73747", "AQAAAAIAAYagAAAAENQLIJ3V/zcYt0/uFhDCPE5YZ7z92gz2fmr/LWHPljELAmBr7Wk9ZvtSioAPqWiBlg==", "a8ee0426-fbff-447a-859d-8c6dc747d7b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a3c7dd8-4e56-4ceb-88bf-f36518b574de", "AQAAAAIAAYagAAAAENJXfn1ytA+DgVrFywJRPWsa6eWGBIWbR9DYFwt8CrTqf4mrmpQ/+Y+zmiYfHmeJ+Q==", "ac21cc9e-0e9a-4b29-ab7f-39af7498e24c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7501c8d6-9094-4ece-becd-7f86667ab3e3", "AQAAAAIAAYagAAAAENOoA7UX4WiPzGiuenVdwau19yMsXnF7FhbXhj4BOTRXwsHI68PEyki7zO9dKnMHmw==", "e579d87a-d805-48bf-bc42-ca9ff0bc725f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413ac0f8-c704-4345-bb80-8d68788e5167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff9c1d86-8623-492b-95b0-01b8888b85a1", "AQAAAAIAAYagAAAAELPqalPaOyC+0aA66Hq6xb0tKBk3TkqkDgCYdx4YbiLQzHGueqcff4UYWJACU673fw==", "2e279f18-ac7d-4294-abac-820db3a7c1f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6aca084-a294-4cfe-95fe-66c9f5c5fc40", "AQAAAAIAAYagAAAAEHigFQGEEu4gKEKfzrs0fGaGpzNM+h5PefyGn193NmBhwxPaM7N6VYh3dbYU5yQ7fA==", "eade51f8-7ccd-4f95-90de-3ae22186f0a6" });
        }
    }
}
