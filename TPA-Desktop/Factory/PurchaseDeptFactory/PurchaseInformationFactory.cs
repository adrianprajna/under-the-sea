using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.PurchaseDeptFactory
{
    class PurchaseInformationFactory
    {

        public static PurchaseInformation create(int employeeID, string information)
        {
            PurchaseInformation p = new PurchaseInformation();
            p.EmployeeId = employeeID;
            p.Information = information;
            p.Date = DateTime.Now;

            return p;
        }
    }
}
