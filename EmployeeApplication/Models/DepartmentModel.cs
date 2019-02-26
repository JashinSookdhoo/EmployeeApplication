using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EmployeeModel;
using EmployeeDataAccess;

namespace EmployeeApplication.Models
{
    public class DepartmentModel
    {
        private class DataInteraction
        {
            private EmployeeContext db = new EmployeeContext();
            public List<Department> GetAll ()
            {
                return db.Database.SqlQuery<Department>("EXEC dbo.Get_Departments ").ToList();
            }
        }

        DataInteraction di = new DataInteraction();
        public List<Department> GetAll()
        {
            return di.GetAll();

        }

        public enum Departments
        {
            

        }

    }
}