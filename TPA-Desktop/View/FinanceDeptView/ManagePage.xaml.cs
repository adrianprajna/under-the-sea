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
using TPA_Desktop.Controller.RequestController;

namespace TPA_Desktop.View.FinanceDeptView
{
    /// <summary>
    /// Interaction logic for ManagePage.xaml
    /// </summary>
    public partial class ManagePage : Window
    {

        int id;

        public ManagePage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if(txtNote.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            FundRequestController.getInstance().update(id, txtNote.Text, "Accepted");
            MessageBox.Show("Success accept the request!");
            Close();
        }

        private void btnReject_Click(object sender, RoutedEventArgs e)
        {
            if (txtNote.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            FundRequestController.getInstance().update(id, txtNote.Text, "Rejected");
            MessageBox.Show("Success reject the request!");
            Close();
        }
    }
}
