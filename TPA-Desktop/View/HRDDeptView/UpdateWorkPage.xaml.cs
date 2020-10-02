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
    /// Interaction logic for UpdateWorkPage.xaml
    /// </summary>
    public partial class UpdateWorkPage : Window
    {
        int id;

        public UpdateWorkPage(int id)
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

            WorkPerformanceController.getInstance().update(id, txtDetail.Text);
            MessageBox.Show("Success update the data!");
            Close();
        }
    }
}
