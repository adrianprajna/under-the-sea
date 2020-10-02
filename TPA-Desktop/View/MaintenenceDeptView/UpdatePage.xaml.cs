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
using TPA_Desktop.Controller.MaintenenceDeptController;

namespace TPA_Desktop.View.MaintenenceDeptView
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
            if(txtInformation.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            MaintenenceController.getInstance().update(id, txtInformation.Text);
            MessageBox.Show("Success updating data!");
            Close();
        }
    }
}
