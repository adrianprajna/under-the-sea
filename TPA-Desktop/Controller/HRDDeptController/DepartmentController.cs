using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.HRDDeptRepository;

namespace TPA_Desktop.Controller.HRDDeptController
{
    class DepartmentController
    {

        private static DepartmentController controller;

        private DepartmentController()
        {

        }

        public static DepartmentController getInstance()
        {
            if (controller == null)
                controller = new DepartmentController();

            return controller;
        }

        public Department find(string name)
        {
            return DepartmentRepository.find(name);
        }

        public Department find(int id)
        {
            return DepartmentRepository.find(id);
        }


    }
}
