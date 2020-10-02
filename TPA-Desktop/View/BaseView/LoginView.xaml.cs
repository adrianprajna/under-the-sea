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
using TPA_Desktop.Model;

namespace TPA_Desktop.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            var employee = EmployeeController.getInstance().getEmployee(email, password);

            int departmentID = (int)employee.DepartmentID;

            if (employee != null)
            {
                MessageBox.Show("Login Success!");

                IView view = ViewFactory.getInstance(employee);
                view.show();

                Close();
            }
            else MessageBox.Show("Login Failed!");
        }
    }
}
