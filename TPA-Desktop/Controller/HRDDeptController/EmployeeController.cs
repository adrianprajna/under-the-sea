using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.HRDDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository;
using TPA_Desktop.View;
using TPA_Desktop.View.HRDDeptView;

namespace TPA_Desktop.Controller
{
    class EmployeeController
    {

        private static EmployeeController controller;

        private EmployeeController()
        {

        }

        public static EmployeeController getInstance()
        {
            if (controller == null)
                controller = new EmployeeController();

            return controller;
        }

        public Employee getEmployee(string email, string password)
        {
            return EmployeeRepository.getEmployee(email, password);
        }

        public dynamic getAll()
        {
            return EmployeeRepository.getAll();
        }

        public List<Employee> getAlls()
        {
            return EmployeeRepository.getAlls();
        }

        public void add(string name, string password, string email, string address, DateTime dob,
            int salary, int departmentID)
        {
            var employee = EmployeeFactory.create(name, password, email, address, dob,
             salary, departmentID);

            EmployeeRepository.add(employee);
        }

        public void update(int id, string name, string password, string email, string address, DateTime dob,
            int salary, int departmentID)
        {
            EmployeeRepository.update(id, name, password, email, address, dob, salary, departmentID);
        }

        public void fire(int id)
        {
            EmployeeRepository.fire(id);
        }

        public LoginView viewLogin()
        {
            return new LoginView();
        }

        public AddPage viewAdd()
        {
            return new AddPage();
        }

        public UpdatePage viewUpdate(int id)
        {
            return new UpdatePage(id);
        }


    }
}
