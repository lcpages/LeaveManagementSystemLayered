using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifyLeaveAllocationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "LeaveAllocations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0065b14e-2443-4a02-84e1-965396006771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47513a8c-3ad2-40e5-9686-f46fcd8f46ef", "AQAAAAIAAYagAAAAEA8De92dL6DxlYgVbpoH7N2XAbhUbgHk+fz+N2R0f20+5HHgVREpvXMHqldxVEFuoA==", "ff0d70de-e03c-4828-9b65-98abf7dac2b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413ac0f8-c704-4345-bb80-8d68788e5167",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02452ebe-aa22-454f-9a2d-6626809f4aeb", "AQAAAAIAAYagAAAAEOIP9UWK9DgYs7fZlysBjT4dwzo/ZwgubUuoNR5zZsVWvMu9upfK+TOdNNl0hl23ww==", "91842391-30c8-4be1-8e9b-55ecde31e8b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e1349f4-cc64-4ba4-a5de-74a500d5d5ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e57162f-50bf-46e0-be73-e1582467d2d0", "AQAAAAIAAYagAAAAEKQNTK1EVvZ5W8ntK6xPDKkqmBtu3aanimWC7jxC40VsBIYmoZN2SVsN/7ifNnHo2w==", "3e269a57-5589-4dc5-a620-c20d645a5844" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Days",
                table: "LeaveAllocations");

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
        }
    }
}
