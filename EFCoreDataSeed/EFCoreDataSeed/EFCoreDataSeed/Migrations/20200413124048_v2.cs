using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDataSeed.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 3,
                column: "Name",
                value: "Production");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 3,
                column: "Name",
                value: "Development");
        }
    }
}
