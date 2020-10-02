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
using TPA_Desktop.Model;

namespace TPA_Desktop.View.HRDDeptView
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        int id;

        public UpdatePage(int id)
        {
            InitializeComponent();
            this.id = id;
            load();
        }

        private void load()
        {
            List<Employee> em = EmployeeController.getInstance().getAlls();
            var filtered = em.Select(i => i.Department.Name);
            cbDept.ItemsSource = filtered;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int salary;
            int.TryParse(txtSalary.Text, out salary);

            DateTime time = (DateTime)date.SelectedDate;
            string departmentName = cbDept.SelectionBoxItem.ToString();

            if (txtName.Text == "" || txtEmail.Text == "" || txtPass.Text == ""
                 || txtSalary.Text == "" || departmentName == "" || time.ToString() == "" ||
                txtAddress.Text == "")
            {
                MessageBox.Show("Invalid input");
                return;
            }

            int deparmentID = DepartmentController.getInstance().find(departmentName).Id;

            EmployeeController.getInstance().update(id, txtName.Text, txtPass.Text, txtEmail.Text,
                txtAddress.Text, time, salary, deparmentID);

            MessageBox.Show("Success updating employee data!");
            Close();
        }
    }
}
