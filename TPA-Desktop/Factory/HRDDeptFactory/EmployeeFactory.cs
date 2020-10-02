using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.HRDDeptFactory
{
    class EmployeeFactory
    {

        public static Employee create(string name, string password, string email, string address, DateTime dob,
            int salary, int departmentID)
        {
            Employee e = new Employee();
            e.Name = name;
            e.Password = password;
            e.Email = email;
            e.Address = address;
            e.DOB = dob;
            e.Salary = salary;
            e.DepartmentID = departmentID;
            e.Status = "Active";

            return e;
        }
    }
}
