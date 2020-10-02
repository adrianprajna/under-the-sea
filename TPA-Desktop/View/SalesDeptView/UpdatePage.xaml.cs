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
using TPA_Desktop.Controller.SalesDeptController;

namespace TPA_Desktop.View.SalesDeptView
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
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtTitle.Text == "" || txtDesc.Text == "")
            {
                MessageBox.Show("Invalid input!");
                txtTitle.Clear();
                txtDesc.Clear();
                return;
            }

            if (AdvertisementController.getInstance().update(id, txtTitle.Text, txtDesc.Text))
                MessageBox.Show("Success update the data!");

            else
                MessageBox.Show("The data is no longer active! Error updating data");

            Close();
        }
    }
}
