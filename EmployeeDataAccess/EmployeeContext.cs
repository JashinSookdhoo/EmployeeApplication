using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace EmployeeDataAccess
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=DbConnectionString") { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<EmployeeModel.EmployeeByDept> EmployeeByDepts { get; set; }
    }
}
