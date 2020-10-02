using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TPA_Desktop.Controller;
using TPA_Desktop.Controller.HRDDeptController;
using TPA_Desktop.Controller.PurchaseDeptController;
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View.PurchaseDeptView
{
    /// <summary>
    /// Interaction logic for PurchaseView.xaml
    /// </summary>
    public partial class PurchaseView : Window, IView
    {
        Employee employee;

        public PurchaseView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        public void show()
        {
            Show();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            var purchase = PurchaseRequestController.getInstance().find(id);
            int money = 0;
            
            if(txtMoney.Text == "")
            {
                MessageBox.Show("Predicted money has to be inputted!");
                return;
            }

            int.TryParse(txtMoney.Text, out money);

            FundRequestController.getInstance().add((int)employee.DepartmentID, purchase.Information, money);
            PurchaseRequestController.getInstance().update(id);
            MessageBox.Show("Success send request fund!");

            load();
        }

        private void load()
        {
            List<PurchaseRequest> purchase_requests = PurchaseRequestController.getInstance().getAll();
            List<FundRequest> fund_requests = FundRequestController.getInstance().getAll();

            var purchase_status = purchase_requests.Where(r => r.Status == "Pending");

            var fund_status = fund_requests.Where(r => r.Status != "Notified" && r.DepartmentId == employee.DepartmentID && r.Status != "Pending");

            var purchase_filtered = purchase_status.Select(r => new
            {
                r.Id,
                DepartmentName = DepartmentController.getInstance().find((int)r.DepartmentId).Name,
                r.Information,
                r.Date
            });

            var fund_fltered = fund_status.Select(r => new
            {
                r.Id,
                r.Information,
                r.Date,
                r.Note,
                r.Status
            });

            txtName.Text = "Good to see you back, " + employee.Name + "!";

            viewPurchaseRequest.ItemsSource = purchase_filtered;
            viewFundRequest.ItemsSource = fund_fltered;
            viewPers.ItemsSource = getPersList();
            viewPurchaseInformation.ItemsSource = getPurInfList();
        }

        private dynamic getPurInfList()
        {
            List<PurchaseInformation> purchases = PurchaseInformationController.getInstance().getAll();

            var filtered = purchases.Select(p => new
            {
                p.Id,
                p.EmployeeId,
                EmployeeName = p.Employee.Name,
                p.Information,
                p.Date
            });

            return filtered;
        }

        private dynamic getPersList()
        {
            List<PersonalRequest> pers_reqs = PersonalRequestController.getInstance().getAll();

            var pers_status = pers_reqs.Where(p => p.EmployeeID == employee.Id && (p.Status == "Accepted" || p.Status == "Rejected"));

            var pers_filterd = pers_status.Select(p => new
            {
                p.Id,
                p.Title,
                p.Description,
                p.Date,
                p.Note,
                p.Status,
                p.Type
            });

            return pers_filterd;
        }

        private void btnNotify_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            if(txtNote.Text == "")
            {
                MessageBox.Show("Note has to be inputted!");
                return;
            }

            var fund = FundRequestController.getInstance().find(id);

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Notify Confirmation", System.Windows.MessageBoxButton.YesNo);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                PurchaseRequestController.getInstance().notify(get(id, fund), fund.Status, txtNote.Text);
                FundRequestController.getInstance().update(fund.Id, fund.Note, "Notified");
                MessageBox.Show("Success notify to the department!");
                load();
            }

            
        }

        private int get(int fundID, dynamic fund)
        {
            List<PurchaseRequest> purchases = PurchaseRequestController.getInstance().getAll();

            foreach(PurchaseRequest p in purchases)
            {
                if (p.Status == "Sent" && p.Information == fund.Information) return p.Id;
            }

            return 0;
        }

        private void btnPersonal_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescPersonal.Text == "" || txtTitlePersonal.Text == "")
            {
                MessageBox.Show("Invalid Input");
                return;
            }

            if (btnLeaving.IsChecked == true)
            {
                PersonalRequestController.getInstance().add(employee.Id, txtTitlePersonal.Text, txtDescPersonal.Text, "Leaving permit");
                MessageBox.Show("Success send leaving permit request!");
            }
            else
            {
                PersonalRequestController.getInstance().add(employee.Id, txtTitlePersonal.Text, txtDescPersonal.Text, "Resignation");
                MessageBox.Show("Success send resignation letter!");
            }

            txtTitlePersonal.Clear();
            txtDescPersonal.Clear();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(txtPurchase.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            PurchaseInformationController.getInstance().add(employee.Id, txtPurchase.Text);
            MessageBox.Show("Success add data!");
            load();
        }
    }
}
