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
using TPA_Desktop.Controller.CreativeDeptController;
using TPA_Desktop.Controller.MaintenenceDeptController;
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View.MaintenenceDeptView
{
    /// <summary>
    /// Interaction logic for MaintenenceView.xaml
    /// </summary>
    public partial class MaintenenceView : Window, IView
    {
        Employee employee;

        public MaintenenceView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        private void load()
        {         
            List<AttractionRide> attr_ride = AttractionRideController.getInstance().getAll();            
            var obj = attr_ride.Select(a => a.Name);

            txtName.Text = "Good to see you back, " + employee.Name + "!";
            cbMaintenence.ItemsSource = obj;
            viewMaintenence.ItemsSource = getMaintenencesList();
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

        private dynamic getMaintenencesList()
        {
            List<Maintenence> maintenences = MaintenenceController.getInstance().getAll();

            var filtered = maintenences.Select(i => new
            {
                i.Id,
                Name = i.AttractionRide.Name,
                i.Information,
                i.Status
            });

            return filtered;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            var attr_ride = MaintenenceController.getInstance().find(id);
            int attr_rideID = attr_ride.AttractionRide.Id;

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);

            if(messageBoxResult == MessageBoxResult.Yes)
            {
                MaintenenceController.getInstance().remove(id, attr_rideID);
                MessageBox.Show("Success finish the maintenence!");
            }

            load();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string attr_ride_name = cbMaintenence.SelectionBoxItem.ToString();
            int attr_ride_id = getAttr_rideID(attr_ride_name);         

            if(attr_ride_name == "" || txtInformation.Text == "")
            {
                MessageBox.Show("Invalid Input!");
                return;
            }

            if(attr_ride_id == 0)
            {
                MessageBox.Show("Attraction or Ride is under maintenence!");
                return;
            }

            MaintenenceController.getInstance().add(attr_ride_id, txtInformation.Text);
            MessageBox.Show("Success add new maintenance schedule");

            reset();
            load();
        }

        private int getAttr_rideID(string attr_ride_name)
        {
            int id = 0;

            List<AttractionRide> lists = AttractionRideController.getInstance().getAll();
            foreach (AttractionRide a in lists)
            {
                if (a.Name == attr_ride_name)
                {
                    id =  a.Id;
                    break;
                }
            }
            return (checkID(id)) ? id : 0;
        }


        private bool checkID(int id)
        {
            List<Maintenence> maintenences = MaintenenceController.getInstance().getAll();
            foreach(Maintenence m in maintenences)
            {
                if (m.AttractionRideID == id) return false;
            }
            return true;
        }


        public void show()
        {
            Show();
        }

        private void reset()
        {
            txtInformation.Clear();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            MaintenenceController.getInstance().viewUpdate(id).Show();
            load();
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
    }
}
