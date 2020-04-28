using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreDataSeed.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public virtual EmployeeAddress EmployeeAddress { get; set; }
        public virtual ICollection<EmployeesInProject> Projects { get; set; }
    }

    public class EmployeeAddress
    {
        [Key, ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public string Address { get; set; }
        public virtual Employee Employee { get; set; }
    }


    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }

    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<EmployeesInProject> Employees { get; set; }
    }

    public class EmployeesInProject
    {
        public int EmployeeID { get; set; }
        public int ProjectID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
    }
}
