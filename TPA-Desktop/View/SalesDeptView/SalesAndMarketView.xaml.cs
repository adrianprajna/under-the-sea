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
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Controller.SalesDeptController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View.SalesDeptView
{
    /// <summary>
    /// Interaction logic for SalesAndMarketView.xaml
    /// </summary>
    public partial class SalesAndMarketView : Window, IView
    {

        Employee employee;

        public SalesAndMarketView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            AdvertisementController.getInstance().add(txtTitle.Text, txtDescription.Text);
            MessageBox.Show("Success add new advertisement!");

            reset();
            load();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            AdvertisementController.getInstance().viewUpdate(id).Show();
            load();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                if (AdvertisementController.getInstance().remove(id))
                    MessageBox.Show("Success remove the data!");

                else
                    MessageBox.Show("Only active data can be removed!");
            }

            load();
        }

        public void show()
        {
            Show();
        }

        private void load()
        {
            txtName.Text = "Good to see you back, " + employee.Name + "!";


            viewAdvertisement.ItemsSource = AdvertisementController.getInstance().getAll();
            viewPers.ItemsSource = getPersList();
            viewPurchase.ItemsSource = getPurchaseList();
            viewFund.ItemsSource = getFundList();
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

        private dynamic getFundList()
        {
            List<FundRequest> funds = FundRequestController.getInstance().getAll();

            var funds_status = funds.Where(p => (p.Status == "Accepted" || p.Status == "Rejected") &&
                                            p.DepartmentId == employee.DepartmentID);

            return funds_status;
        }

        private dynamic getPurchaseList()
        {
            List<PurchaseRequest> reqs = PurchaseRequestController.getInstance().getAll();

            var req_status = reqs.Where(p => (p.Status == "Accepted" || p.Status == "Rejected") &&
                                            p.DepartmentId == employee.DepartmentID);

            var req_filtered = req_status.Select(p => new
            {
                p.Id,
                p.Information,
                p.Note,
                p.Status,
                p.Date
            });

            return req_filtered;
        }

        private void reset()
        {
            txtTitle.Clear();
            txtDescription.Clear();
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
            if (txtPurchase.Text == "")
            {
                MessageBox.Show("Invalid Input!");
                return;
            }

            PurchaseRequestController.getInstance().add((int)employee.DepartmentID, txtPurchase.Text);
            MessageBox.Show("Success request for purchase!");
            txtPurchase.Clear();
        }

        private void btnFund_Click(object sender, RoutedEventArgs e)
        {
            if (txtFund.Text == "" || txtMoney.Text == "")
            {
                MessageBox.Show("Invalid Input");
                return;
            }

            int money;
            bool success = int.TryParse(txtMoney.Text, out money);

            if (success)
            {
                FundRequestController.getInstance().add((int)employee.DepartmentID, txtFund.Text, money);
                MessageBox.Show("Success request for fund!");
                txtFund.Clear();
                txtMoney.Clear();
            }
            else MessageBox.Show("Money must be numeric");
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
    }
}
