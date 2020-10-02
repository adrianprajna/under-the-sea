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
using TPA_Desktop.Model;

namespace TPA_Desktop.View.HotelDeptView
{
    /// <summary>
    /// Interaction logic for AddReservation.xaml
    /// </summary>
    public partial class AddReservation : Window
    {

        int visitorID;
        int employeeID;

        public AddReservation(int employeeID, int visitorID)
        {
            InitializeComponent();
            this.visitorID = visitorID;
            this.employeeID = employeeID;
            load();
        }

        private void load()
        {
            viewRoom.ItemsSource = RoomController.getInstance().getAll();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            if(txtNight.Text == "")
            {
                MessageBox.Show("Please input how many nights!");
                return;
            }

            List<Reservation> reservations = ReservationController.getInstance().getAll();

            foreach (Reservation r in reservations)
            {
                if (r.VisitorId == visitorID && (r.Status == "Booked" || r.Status == "Check in"))
                {
                    MessageBox.Show("This visitor has been in a reservation!");
                    Close();
                    return;
                }
            }

            int night;
            bool success = int.TryParse(txtNight.Text, out night);

            if (success)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Add Reservation Confirmation", System.Windows.MessageBoxButton.YesNo);

                if(messageBoxResult == MessageBoxResult.Yes)
                {
                    var room = RoomController.getInstance().find(id);
                    if (ReservationController.getInstance().add(employeeID, visitorID, id, "", night, night * (int)room.Price))
                    {
                        MessageBox.Show("Success add new reservation!");
                        Close();
                    }
                    else
                        MessageBox.Show("Cannot select the booked room!");

                }
               
            }
            else
                MessageBox.Show("Must be numeric!");

        }
    }
}
