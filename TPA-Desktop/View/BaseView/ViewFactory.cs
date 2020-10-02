using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;
using TPA_Desktop.View.ConstructionDeptView;
using TPA_Desktop.View.FinanceDeptView;
using TPA_Desktop.View.HRDDeptView;
using TPA_Desktop.View.MaintenenceDeptView;
using TPA_Desktop.View.PurchaseDeptView;
using TPA_Desktop.View.SalesDeptView;
using TPA_Desktop.View.ManagerView;
using TPA_Desktop.View.AttractionDeptView;
using TPA_Desktop.View.HotelDeptView;

namespace TPA_Desktop.View
{
    class ViewFactory
    {
        static IView view;

        public static IView getInstance(Employee employee)
        {
            if (employee.DepartmentID == 4) view = new CreativeView(employee);

            else if (employee.DepartmentID == 5) view = new ConstructionView(employee);

            else if (employee.DepartmentID == 6) view = new SalesAndMarketView(employee);

            else if (employee.DepartmentID == 2) view = new HRDView(employee);

            else if (employee.DepartmentID == 3) view = new MaintenenceView(employee);

            else if (employee.DepartmentID == 10) view = new PurchaseView(employee);

            else if (employee.DepartmentID == 9) view = new FinanceView(employee);

            else if (employee.DepartmentID == 13) view = new ManagerView.ManagerView(employee);

            else if (employee.DepartmentID == 1) view = new AttractionView(employee);

            else if (employee.DepartmentID == 8) view = new FrontOfficeView(employee);

            return view;
        }


    }
}
