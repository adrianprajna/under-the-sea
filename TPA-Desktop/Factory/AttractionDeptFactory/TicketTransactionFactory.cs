using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.AttractionDeptFactory
{
    class TicketTransactionFactory
    {

        public static TicketTransaction create(int employeeId, int quantity)
        {
            TicketTransaction t = new TicketTransaction();
            t.EmployeeId = employeeId;
            t.Date = DateTime.Now;
            t.Quantity = quantity;
            t.TotalPrice = quantity * 100000;

            return t;
        }
    }
}
