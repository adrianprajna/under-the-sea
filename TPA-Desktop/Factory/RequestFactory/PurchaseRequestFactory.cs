using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.RequestFactory
{
    class PurchaseRequestFactory
    {

        public static PurchaseRequest create(int departmentID, string information)
        {
            PurchaseRequest p = new PurchaseRequest();
            p.DepartmentId = departmentID;
            p.Information = information;
            p.Date = DateTime.Now;
            p.Status = "Pending";
            p.Note = "";
            return p;
        }
    }
}
