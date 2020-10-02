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
using TPA_Desktop.Controller.HotelDeptController;
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View.HotelDeptView
{
    /// <summary>
    /// Interaction logic for FrontOfficeView.xaml
    /// </summary>
    public partial class FrontOfficeView : Window, IView
    {
        Employee employee;
        public FrontOfficeView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        private void load()
        {
            txtName.Text = "Good to see you back, " + employee.Name + "!";

            viewVisitor.ItemsSource = getVisitorList();
            viewResercation.ItemsSource = getReservationList();
            viewRoom.ItemsSource = RoomController.getInstance().getAll();
            viewFeedback.ItemsSource = getFeedbackList();
            viewPers.ItemsSource = getPersList();
        }

        private dynamic getPersList()
        {
            List<PersonalRequest> pers_reqs = PersonalRequestController.getInstance().getAll();

            var pers_status = pers_reqs.Where(p => p.EmployeeID == employee.Id && (p.Status == "Accepted" || p.Status == "Rejected"));

            var pers_filterd = pers_status.Select(p => new
            {
                p.Id,
                p.Title,
                p.Description,
                p.Date,
                p.Note,
                p.Status,
                p.Type
            });

            return pers_filterd;
        }

        private dynamic getFeedbackList()
        {
            List<Feedback> feedbacks = FeedbackController.getInstance().getAll();

            var feedback_status = feedbacks.Where(f => f.Type == "Hotel");

            var feedback_filtered = feedback_status.Select(f => new
            {
                f.Id,
                RoomId = f.Reservation.RoomId,
                RoomName = f.Reservation.Room.Description,
                f.Description
            });

            return feedback_filtered;
        }

        private dynamic getReservationList()
        {
            List<Reservation> reservations = ReservationController.getInstance().getAll();

            var reservations_status = reservations.Where(r => r.Status == "Booked" || r.Status == "Check in");

            var reservation_filtered = reservations_status.Select(r => new
            {
                r.Id,
                r.EmployeeId,
                r.VisitorId,
                r.RoomId,
                r.CheckInDate,
                r.CheckOutDate,
                r.TotalPrice
            });

            return reservation_filtered;
        }

        private dynamic getVisitorList()
        {
            List<Visitor> visitors = VisitorController.getInstance().getAll();

            var visitors_stats = visitors.Where(v => v.Status == "Active");

            var visitors_filterd = visitors_stats.Select(v => new
            {
                v.Id,
                v.Name,
                v.DOB,
                v.Email,
                v.phoneNumber

            });

            return visitors_filterd;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        private void btnAddReservation_Click(object sender, RoutedEventArgs e)
        {

            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            ReservationController.getInstance().openAddReservation(employee.Id, id).Show();
            load();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            if (txtNameVis.Text == "" || datepick.SelectedDate.Equals(null) || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            DateTime dob = (DateTime)datepick.SelectedDate;

            VisitorController.getInstance().update(id, txtNameVis.Text, dob, txtEmail.Text, txtPhone.Text);
            MessageBox.Show("Success update visitor data!");
            reset();
            load();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);

            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                VisitorController.getInstance().remove(id);
                MessageBox.Show("Success remove visitor data!");
            }
            load();

        }

        public void show()
        {
            Show();
        }

        private void btnPersonal_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescPersonal.Text == "" || txtTitlePersonal.Text == "")
            {
                MessageBox.Show("Invalid Input");
                return;
            }

            if (btnLeaving.IsChecked == true)
            {
                PersonalRequestController.getInstance().add(employee.Id, txtTitlePersonal.Text, txtDescPersonal.Text, "Leaving permit");
                MessageBox.Show("Success send leaving permit request!");
            }
            else
            {
                PersonalRequestController.getInstance().add(employee.Id, txtTitlePersonal.Text, txtDescPersonal.Text, "Resignation");
                MessageBox.Show("Success send resignation letter!");
            }

            txtTitlePersonal.Clear();
            txtDescPersonal.Clear();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(txtNameVis.Text == "" || datepick.SelectedDate.Equals(null) || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            DateTime dob = (DateTime)datepick.SelectedDate;

            VisitorController.getInstance().add(txtNameVis.Text, dob, txtEmail.Text, txtPhone.Text);
            MessageBox.Show("Success add new visitor!");
            reset();
            load();
        }

        private void reset()
        {
            txtNameVis.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            datepick.Text = "";
        }

        private void btnCheckIn_Click(object sender, RoutedEventArgs e)
        {

            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Check In Confirmation", System.Windows.MessageBoxButton.YesNo);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                Reservation reservation = ReservationController.getInstance().find(id);
                if (reservation.Status != "Check in")
                {
                    Room room = RoomController.getInstance().find((int)reservation.RoomId);

                    ReservationController.getInstance().update(id, "Check in", room);
                    MessageBox.Show("Success check in");
                    load();

                }
                else
                    MessageBox.Show("Visitor has checked in!");
            }
        }

        private void btnCheckOut_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Check Out Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Reservation reservation = ReservationController.getInstance().find(id);
                if (reservation.Status == "Check in")
                {
                    FeedbackController.getInstance().openFeedback(id).Show();
                    Room room = RoomController.getInstance().find((int)reservation.RoomId);

                    ReservationController.getInstance().update(id, "Check out", room);
                    MessageBox.Show("Success check out");
                    load();
                }
                else
                    MessageBox.Show("Cannot check out before check in!");
            }
        }

        private void btnUpdateRes_Click(object sender, RoutedEventArgs e)
        {
            if(txtOldInn.Text == "")
            {
                MessageBox.Show("Please input data below!");
                return;
            }

            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            int night;
            bool success = int.TryParse(txtOldInn.Text, out night);

            if (success)
            {
                ReservationController.getInstance().update(id, night);
                MessageBox.Show("Success update reservation data!");
                txtOldInn.Clear();
            }
            else
                MessageBox.Show("Inn must be numeric");

            load(); 
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Cancel Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Reservation reservation = ReservationController.getInstance().find(id);

                Room room = RoomController.getInstance().find((int)reservation.RoomId);

                ReservationController.getInstance().remove(id, room);
                MessageBox.Show("Success cancel the reservation!");
                load();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            load();
        }
    }
}
