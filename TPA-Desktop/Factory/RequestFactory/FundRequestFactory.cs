using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.RequestFactory
{
    class FundRequestFactory
    {
        public static FundRequest create(int departmentID, string information, int money)
        {
            FundRequest f = new FundRequest();
            f.DepartmentId = departmentID;
            f.Information = information;
            f.AmountMoney = money;
            f.Date = DateTime.Now;
            f.Note = "";
            f.Status = "Pending";

            return f;
        }



    }
}
