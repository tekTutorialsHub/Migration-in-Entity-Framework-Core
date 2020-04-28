using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDataSeed.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeAddress",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeAddress",
                keyColumn: "EmployeeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeAddress",
                keyColumn: "EmployeeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EmployeesInProject",
                keyColumns: new[] { "EmployeeID", "ProjectID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeesInProject",
                keyColumns: new[] { "EmployeeID", "ProjectID" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeesInProject",
                keyColumns: new[] { "EmployeeID", "ProjectID" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeesInProject",
                keyColumns: new[] { "EmployeeID", "ProjectID" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "EmployeesInProject",
                keyColumns: new[] { "EmployeeID", "ProjectID" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "EmployeesInProject",
                keyColumns: new[] { "EmployeeID", "ProjectID" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "Name" },
                values: new object[] { 5, "Production" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 5, 3, "Muhammad Ali" },
                    { 8, 3, "Rafael Nadal" },
                    { 6, 3, "Michael Schumacher" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeAddress",
                columns: new[] { "EmployeeID", "Address" },
                values: new object[,]
                {
                    { 5, "Kentuki, USA" },
                    { 8, "Manacor, Spain" },
                    { 6, "Hurth, Germany" }
                });

            migrationBuilder.InsertData(
                table: "EmployeesInProject",
                columns: new[] { "EmployeeID", "ProjectID" },
                values: new object[,]
                {
                    { 5, 2 },
                    { 5, 3 },
                    { 8, 5 },
                    { 8, 6 },
                    { 6, 2 },
                    { 6, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "Name" },
                values: new object[] { 3, "Production" });
        }
    }
}
