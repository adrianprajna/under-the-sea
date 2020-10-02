using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository
{
    class EmployeeRepository
    {
        private static DatabaseEntities db = Connect.getInstance();


        public static Employee getEmployee(string email, string password)
        {
            return (from employee in db.Employees
                    where employee.Email == email
                    && employee.Password == password
                    select employee).FirstOrDefault();
        }

        public static dynamic getAll()
        {
            return (from employee in db.Employees
                    join department in db.Departments
                    on employee.DepartmentID equals department.Id
                    where employee.Status == "Active"
                    select new {employee.Id, employee.Name, employee.Email,
                    employee.DOB, employee.Salary, DeptName = department.Name }).ToList();
        }

        public static void fire(int id)
        {
            var employee = (from e in db.Employees
                            where e.Id == id
                            select e).FirstOrDefault();

            employee.Status = "Fired";

            db.SaveChanges();
        }

        public static void update(int id, string name, string password, string email, string address, DateTime dob,
            int salary, int departmentID)
        {
            var employee = (from e in db.Employees
                            where e.Id == id
                            select e).FirstOrDefault();

            employee.Name = name;
            employee.Password = password;
            employee.Email = email;
            employee.Address = address;
            employee.DOB = dob;
            employee.Salary = salary;
            employee.DepartmentID = departmentID;

            db.SaveChanges();
        }

        public static List<Employee> getAlls()
        {
            return db.Employees.ToList();
        }

        public static void add(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
        }

    }
}
