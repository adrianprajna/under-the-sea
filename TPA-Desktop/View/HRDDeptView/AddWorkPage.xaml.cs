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
using TPA_Desktop.Controller.HRDDeptController;

namespace TPA_Desktop.View.HRDDeptView
{
    /// <summary>
    /// Interaction logic for AddWorkPage.xaml
    /// </summary>
    public partial class AddWorkPage : Window
    {
        int id;

        public AddWorkPage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(txtDetail.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            if (WorkPerformanceController.getInstance().add(id, txtDetail.Text))
            {
                MessageBox.Show("Success add work performance detail!");
                return;
            }
            else MessageBox.Show("You have already added this employee's work perfiormance!");

            Close();
        }
    }
}
