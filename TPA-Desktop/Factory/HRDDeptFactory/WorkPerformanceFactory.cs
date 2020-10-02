using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.HRDDeptFactory
{
    class WorkPerformanceFactory
    {

        public static WorkPerformance create(int employeeId, string performance)
        {
            WorkPerformance w = new WorkPerformance();
            w.EmployeeId = employeeId;
            w.PerformanceDetail = performance;
            w.Status = "Active";

            return w;
        }
    }
}
