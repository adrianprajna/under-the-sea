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
using TPA_Desktop.Controller.CreativeDeptController;

namespace TPA_Desktop.View.CreativeDeptView
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
            if(txtName.Text == "" || txtDesc.Text == "")
            {
                MessageBox.Show("Invalid Input!");
                reset();
                return;
            }

            else
            {
                if(AttractionRideController.getInstance().update(id, txtName.Text, txtDesc.Text))
                    MessageBox.Show("Success update data!");

                else
                    MessageBox.Show("Only active attraction or ride that can be updated!");

                reset();
                Close();
            }
        }


        private void reset()
        {
            txtName.Clear();
            txtDesc.Clear();
        }
    }
}
