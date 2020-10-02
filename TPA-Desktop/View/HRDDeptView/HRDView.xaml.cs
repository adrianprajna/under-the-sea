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
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View.HRDDeptView
{
    /// <summary>
    /// Interaction logic for HRDView.xaml
    /// </summary>
    public partial class HRDView : Window, IView
    {
        Employee employee;

        public HRDView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        private void load()
        {
            txtName.Text = "Good to see you back, " + employee.Name + "!";

            List<PersonalRequest> pers_reqs = PersonalRequestController.getInstance().getAll();

            var pers_status = pers_reqs.Where(p => p.Type == "Leaving permit" && p.Status == "Pending");

            var pers_filtered = pers_status.Select(p => new
            {
                p.Id,
                EmployeeName = p.Employee.Name,
                p.Title,
                p.Description,
                p.Date
            });

            viewEmployee.ItemsSource = EmployeeController.getInstance().getAll();
            viewLeaving.ItemsSource = pers_filtered;
            viewPers.ItemsSource = getPersList();
            viewFund.ItemsSource = getFundList();
            viewWork.ItemsSource = getWorkList();
        }

        private dynamic getWorkList()
        {
            List<WorkPerformance> works = WorkPerformanceController.getInstance().getAll();

            var works_status = works.Where(w => w.Status == "Active").ToList();

            var works_filtered = works_status.Select(w => new
            {
                w.Id,
                w.EmployeeId,
                EmployeeName = w.Employee.Name,
                w.PerformanceDetail
            });

            return works_filtered;
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

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            EmployeeController.getInstance().viewUpdate(id).Show();

            load();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                EmployeeController.getInstance().fire(id);
                MessageBox.Show("Success firing the employee!");
            }

            load();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewAdd().Show();
            load();
        }

        public void show()
        {
            Show();
        }

        private void btnAcc_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Accept Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNote.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                PersonalRequestController.getInstance().update(id, txtNote.Text, "Accepted");
                MessageBox.Show("Success accepted the request!");
            }
            txtNote.Clear();
            load();
        }

        private void btnRej_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Reject Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNote.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                PersonalRequestController.getInstance().update(id, txtNote.Text, "Rejected");
                MessageBox.Show("Success rejected the request!");
            }
            txtNote.Clear();
            load();
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

            if (btnRaise.IsChecked == true)
            {
                PersonalRequestController.getInstance().add(employee.Id, txtTitlePersonal.Text, txtDescPersonal.Text, "Raise salary");
                MessageBox.Show("Success send raise salary request!");
            }

            else if(btnFiring.IsChecked == true)
            {
                PersonalRequestController.getInstance().add(employee.Id, txtTitlePersonal.Text, txtDescPersonal.Text, "Fire employee");
                MessageBox.Show("Success send firing employee request!");
            }
            
            else
            {
                PersonalRequestController.getInstance().add(employee.Id, txtTitlePersonal.Text, txtDescPersonal.Text, "Resignation");
                MessageBox.Show("Success send resignation letter!");
            }

            txtTitlePersonal.Clear();
            txtDescPersonal.Clear();
        }

        private void btnWork_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            WorkPerformanceController.getInstance().openAddWork(id).Show();
            load();
        }

        private void btnUpdateWork_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            WorkPerformanceController.getInstance().openUpdateWork(id).Show();
            load();
        }

        private void btnRemoveWork_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                WorkPerformanceController.getInstance().remove(id);
                MessageBox.Show("Success remove the data!");
                load();
            }         
        }
    }
}
