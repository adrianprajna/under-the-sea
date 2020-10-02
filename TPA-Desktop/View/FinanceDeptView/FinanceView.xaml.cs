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

namespace TPA_Desktop.View.FinanceDeptView
{
    /// <summary>
    /// Interaction logic for FinanceView.xaml
    /// </summary>
    public partial class FinanceView : Window, IView
    {
        Employee employee;
        public FinanceView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        private void load()
        {
            List<FundRequest> requests = FundRequestController.getInstance().getAll();

            var status = requests.Where(r => r.Status == "Pending").ToList();

            var filtered = status.Select(r => new
            {
                r.Id,
                DepartmentName = DepartmentController.getInstance().find((int)r.DepartmentId).Name,
                r.Information,
                r.Date,
                r.AmountMoney,
            });

            txtName.Text = "Good to see you back, " + employee.Name + "!";
            viewFundRequest.ItemsSource = filtered;
            viewPers.ItemsSource = getPersList();
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

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        private void btnNotify_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            FundRequestController.getInstance().viewManage(id).Show();
            load();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

        }

        public void show()
        {
            Show();
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
