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
using TPA_Desktop.Controller.ConstructionDeptController;
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View.ConstructionDeptView
{
    /// <summary>
    /// Interaction logic for ConstructionView.xaml
    /// </summary>
    public partial class ConstructionView : Window, IView
    {
        Employee employee;

        public ConstructionView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            if (ConstructionController.getInstance().start(id))
                MessageBox.Show("Success to start the construction!");

            else
                MessageBox.Show("Construction has been started!");

            load();
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Finish Construction Confirmation", System.Windows.MessageBoxButton.YesNo);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                if (ConstructionController.getInstance().finish(id))
                    MessageBox.Show("Success to finish the construction!");

                else
                    MessageBox.Show("Invalid!");
            }
            load();
        }

        private void load()
        {
            txtName.Text = "Good to see you back, " + employee.Name + "!";

            viewConstruction.ItemsSource = getConsList();
            viewPers.ItemsSource = getPersList();
            viewFund.ItemsSource = getFundList();
            viewPurchase.ItemsSource = getPurchaseList();
        }

        private dynamic getConsList()
        {
            List<Construction> constructions = ConstructionController.getInstance().getAll();

            var cons_status = constructions.Where(c => c.Status == "Waiting for constructing" ||
                                                    c.Status == "In progress of constructing");

            var filtered = cons_status.Select(c => new
            {
                c.Id,
                title = c.Idea.Tittle,
                information = c.Idea.Information,
                c.Status
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



        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        public void show()
        {
            Show();
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
