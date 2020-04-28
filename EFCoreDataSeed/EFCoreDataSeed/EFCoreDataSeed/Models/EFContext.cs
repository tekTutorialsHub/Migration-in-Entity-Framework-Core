using Microsoft.EntityFrameworkCore;

namespace EFCoreDataSeed.Models
{
    public class EFContext : DbContext
    {

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCoreDataSeed;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddress { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<EmployeesInProject> EmployeesInProject { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here   

            modelBuilder.Entity<EmployeesInProject>()
                        .HasKey(e => new { e.EmployeeID, e.ProjectID });

            modelBuilder.Entity<Department>()
                   .HasData(
                     new Department { DepartmentID = 1, Name = "HR" },
                     new Department { DepartmentID = 2, Name = "Admin" },
                     new Department { DepartmentID = 3, Name = "Production" }
                   );

            modelBuilder.Entity<Project>()
                   .HasData(
                     new Project { ProjectID = 1, Name = "Cricket" },
                     new Project { ProjectID = 2, Name = "Politics" },
                     new Project { ProjectID = 3, Name = "Boxing" },
                     new Project { ProjectID = 4, Name = "Racing" },
                     new Project { ProjectID = 5, Name = "Football" },
                     new Project { ProjectID = 6, Name = "Tennis" }
                   );

            modelBuilder.Entity<Employee>()
                   .HasData(
                      new Employee { EmployeeID = 1, Name = "Rahul Dravid", DepartmentID = 1 },
                      new Employee { EmployeeID = 2, Name = "Trump", DepartmentID = 1 },
                      new Employee { EmployeeID = 3, Name = "Barak Obama", DepartmentID = 2 },
                      new Employee { EmployeeID = 4, Name = "Virat Kohli", DepartmentID = 2 },
                      new Employee { EmployeeID = 5, Name = "Muhammad Ali", DepartmentID = 3 },
                      new Employee { EmployeeID = 6, Name = "Michael Schumacher", DepartmentID = 3 },
                      new Employee { EmployeeID = 7, Name = "Lionel Messi", DepartmentID = 2 },
                      new Employee { EmployeeID = 8, Name = "Rafael Nadal", DepartmentID = 3 }
                   );

            modelBuilder.Entity<EmployeeAddress>()
                   .HasData(
                     new EmployeeAddress { EmployeeID = 1, Address = "Bangalore, India" },
                     new EmployeeAddress { EmployeeID = 2, Address = "Newyork, USA" },
                     new EmployeeAddress { EmployeeID = 3, Address = "California, USA" },
                     new EmployeeAddress { EmployeeID = 4, Address = "NewDelhi, India" },
                     new EmployeeAddress { EmployeeID = 5, Address = "Kentuki, USA" },
                     new EmployeeAddress { EmployeeID = 6, Address = "Hurth, Germany" },
                     new EmployeeAddress { EmployeeID = 7, Address = "Rosario, Argentina" },
                     new EmployeeAddress { EmployeeID = 8, Address = "Manacor, Spain" }
                   );

            modelBuilder.Entity<EmployeesInProject>()
                   .HasData(
                      new EmployeesInProject { EmployeeID = 1, ProjectID = 1 },
                      new EmployeesInProject { EmployeeID = 1, ProjectID = 4 },
                      new EmployeesInProject { EmployeeID = 2, ProjectID = 2 },
                      new EmployeesInProject { EmployeeID = 2, ProjectID = 3 },
                      new EmployeesInProject { EmployeeID = 3, ProjectID = 2 },
                      new EmployeesInProject { EmployeeID = 3, ProjectID = 5 },
                      new EmployeesInProject { EmployeeID = 4, ProjectID = 1 },
                      new EmployeesInProject { EmployeeID = 4, ProjectID = 3 },
                      new EmployeesInProject { EmployeeID = 5, ProjectID = 3 },
                      new EmployeesInProject { EmployeeID = 5, ProjectID = 2 },
                      new EmployeesInProject { EmployeeID = 6, ProjectID = 4 },
                      new EmployeesInProject { EmployeeID = 6, ProjectID = 2 },
                      new EmployeesInProject { EmployeeID = 7, ProjectID = 5 },
                      new EmployeesInProject { EmployeeID = 7, ProjectID = 1 },
                      new EmployeesInProject { EmployeeID = 8, ProjectID = 6 },
                      new EmployeesInProject { EmployeeID = 8, ProjectID = 5 }
                   );
        }
    }
}