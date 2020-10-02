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
using TPA_Desktop.Controller.HotelDeptController;

namespace TPA_Desktop.View.HotelDeptView
{
    /// <summary>
    /// Interaction logic for Feedback.xaml
    /// </summary>
    public partial class FeedbackPage : Window
    {
        int resID;
        public FeedbackPage(int resID)
        {
            InitializeComponent();
            this.resID = resID;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(txtDesc.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            FeedbackController.getInstance().add(resID, txtDesc.Text, "Hotel");
            MessageBox.Show("Success input feedback!");
            Close();
        }
    }
}
