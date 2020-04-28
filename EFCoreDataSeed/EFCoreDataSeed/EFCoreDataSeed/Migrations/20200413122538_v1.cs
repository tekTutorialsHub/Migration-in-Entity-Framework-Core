using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDataSeed.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DepartmentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAddress",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAddress", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesInProject",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesInProject", x => new { x.EmployeeID, x.ProjectID });
                    table.ForeignKey(
                        name: "FK_EmployeesInProject_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesInProject_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 1, "HR" },
                    { 2, "Admin" },
                    { 3, "Development" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectID", "Name" },
                values: new object[,]
                {
                    { 1, "Cricket" },
                    { 2, "Politics" },
                    { 3, "Boxing" },
                    { 4, "Racing" },
                    { 5, "Football" },
                    { 6, "Tennis" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Rahul Dravid" },
                    { 2, 1, "Trump" },
                    { 3, 2, "Barak Obama" },
                    { 4, 2, "Virat Kohli" },
                    { 7, 2, "Lionel Messi" },
                    { 5, 3, "Muhammad Ali" },
                    { 6, 3, "Michael Schumacher" },
                    { 8, 3, "Rafael Nadal" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeAddress",
                columns: new[] { "EmployeeID", "Address" },
                values: new object[,]
                {
                    { 1, "Bangalore, India" },
                    { 8, "Manacor, Spain" },
                    { 2, "Newyork, USA" },
                    { 6, "Hurth, Germany" },
                    { 3, "California, USA" },
                    { 4, "NewDelhi, India" },
                    { 5, "Kentuki, USA" },
                    { 7, "Rosario, Argentina" }
                });

            migrationBuilder.InsertData(
                table: "EmployeesInProject",
                columns: new[] { "EmployeeID", "ProjectID" },
                values: new object[,]
                {
                    { 6, 2 },
                    { 6, 4 },
                    { 5, 2 },
                    { 5, 3 },
                    { 7, 1 },
                    { 4, 3 },
                    { 8, 6 },
                    { 4, 1 },
                    { 3, 5 },
                    { 3, 2 },
                    { 2, 3 },
                    { 2, 2 },
                    { 1, 4 },
                    { 1, 1 },
                    { 7, 5 },
                    { 8, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID",
                table: "Employee",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesInProject_ProjectID",
                table: "EmployeesInProject",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAddress");

            migrationBuilder.DropTable(
                name: "EmployeesInProject");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
