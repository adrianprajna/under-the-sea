using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.HRDDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.HRDDeptRepository;
using TPA_Desktop.View.HRDDeptView;

namespace TPA_Desktop.Controller.HRDDeptController
{
    class WorkPerformanceController
    {
        private static WorkPerformanceController controller;

        private WorkPerformanceController()
        {

        }

        public static WorkPerformanceController getInstance()
        {
            if (controller == null)
                controller = new WorkPerformanceController();

            return controller;
        }

        public List<WorkPerformance> getAll()
        {
            return WorkPerformanceRepository.getAll();
        }

        public bool add(int employeeId, string performance)
        {
            List<WorkPerformance> works = getAll();
            foreach(WorkPerformance work in works)
            {
                if (work.EmployeeId == employeeId && work.Status == "Active") return false;
            }

            WorkPerformance w = WorkPerformanceFactory.create(employeeId, performance);
            WorkPerformanceRepository.add(w);
            return true;
        }

        public void update(int id, string performance)
        {
            WorkPerformanceRepository.update(id, performance);
        }

        public void remove(int id)
        {
            WorkPerformanceRepository.remove(id);
        }
        
        public UpdateWorkPage openUpdateWork(int id)
        {
            return new UpdateWorkPage(id);
        }

        public AddWorkPage openAddWork(int id)
        {
            return new AddWorkPage(id);
        }
    }
}
