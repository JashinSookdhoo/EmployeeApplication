using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeModel;
using EmployeeDataAccess;
using System.Data.SqlClient;

namespace EmployeeApplication.Models
{
    public class EmployeeByDeptModel
    {
        private class DataInteraction
        {
            private EmployeeContext db = new EmployeeContext();
            public List<EmployeeByDept> Get() {
                return db.Database.SqlQuery<EmployeeByDept>("EXEC dbo.EmployeeByDept ").ToList();
            }

            public List<EmployeeByDept> GetByDept(string DepartmentId)
            {
                if (DepartmentId != null)
                {
                    SqlParameter dept = new SqlParameter("@Dept", DepartmentId);
                    return db.Database.SqlQuery<EmployeeByDept>("EXEC dbo.EmployeeByDept @Dept ", dept).ToList();
                }
                else
                {
                    return db.Database.SqlQuery<EmployeeByDept>("EXEC dbo.EmployeeByDept ").ToList();


                };
            }

        }

        DataInteraction di = new DataInteraction();
        public List<EmployeeByDept> Get()
        {
            return di.Get();

        }

        public List<EmployeeByDept> GetByDept(string DepartmentId) {
            //Returns a list of all employees in all departments and can be filtered per department
            return di.GetByDept(DepartmentId);
        }


    }
}