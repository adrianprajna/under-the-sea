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
using TPA_Desktop.Controller.HRDDeptController;
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View.ManagerView
{
    /// <summary>
    /// Interaction logic for ManagerView.xaml
    /// </summary>
    public partial class ManagerView : Window, IView
    {
        Employee employee;

        public ManagerView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            Load();
        }

        private void Load()
        {
            txtName.Text = "Good to see you back, " + employee.Name + "!";

            List<PersonalRequest> pers_reqs = PersonalRequestController.getInstance().getAll();

            var pers_status = pers_reqs.Where(p => p.Type == "Resignation" && p.Status == "Pending");

            var pers_filtered = pers_status.Select(p => new
            {
                p.Id,
                p.EmployeeID,
                EmployeeName = p.Employee.Name,
                p.Title,
                p.Description,
                p.Date
            });

            viewResign.ItemsSource = pers_filtered;
            viewEmployee.ItemsSource = EmployeeController.getInstance().getAll();
            viewWork.ItemsSource = getWorkList();
            viewRaise.ItemsSource = getRaiseList();
            viewFire.ItemsSource = getFireList();
            viewIdeas.ItemsSource = getIdeaList();
        }

        private dynamic getIdeaList()
        {
            List<Idea> ideas = IdeaController.getInstance().getAll();

            var idea_status = ideas.Where(i => i.Status == "Pending");

            var idea_filtered = idea_status.Select(p => new
            {
                p.Id,
                p.Tittle,
                p.Information,
                p.Date,
            });

            return idea_filtered;
        }

        private dynamic getWorkList()
        {
            List<WorkPerformance> works = WorkPerformanceController.getInstance().getAll();

            var works_status = works.Where(w => w.Status == "Active").ToList();

            var works_filtered = works_status.Select(w => new
            {
                w.Id,
                w.EmployeeId,
                EmployeeName = w.Employee.Name,
                w.PerformanceDetail
            });

            return works_filtered;
        }

        private dynamic getRaiseList()
        {
            List<PersonalRequest> raises = PersonalRequestController.getInstance().getAll();

            var raise_status = raises.Where(p => p.Type == "Raise salary" && p.Status == "Pending");

            var raise_filtered = raise_status.Select(p => new
            {
                p.Id,
                p.Title,
                p.Description,
                p.Date
            });

            return raise_filtered;
        }

        private dynamic getFireList()
        {
            List<PersonalRequest> fires = PersonalRequestController.getInstance().getAll();

            var fires_status = fires.Where(p => p.Type == "Fire employee" && p.Status == "Pending");

            var fires_filtered = fires_status.Select(p => new
            {
                p.Id,
                p.Title,
                p.Description,
                p.Date
            });

            return fires_filtered;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        private void btnAccRes_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Accept Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNote.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                PersonalRequestController.getInstance().update(id, txtNote.Text, "Accepted");
                MessageBox.Show("Success accepted the request!");
            }
            txtNote.Clear();
            Load();
        }

        private void btnRejRes_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Reject Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNote.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                PersonalRequestController.getInstance().update(id, txtNote.Text, "Rejected");
                MessageBox.Show("Success rejected the request!");
            }
            txtNote.Clear();
            Load();
        }

        public void show()
        {
            Show();
        }

        private void btnAccRaise_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Accept Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNoteRaise.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                PersonalRequestController.getInstance().update(id, txtNoteRaise.Text, "Accepted");
                MessageBox.Show("Success accepted the request!");
            }
            txtNoteRaise.Clear();
            Load();
        }

        private void btnRejRaise_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Reject Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNoteRaise.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                PersonalRequestController.getInstance().update(id, txtNoteRaise.Text, "Rejected");
                MessageBox.Show("Success rejected the request!");
            }
            txtNoteRaise.Clear();
            Load();
        }

        private void btnAccFire_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Accept Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNoteFire.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                PersonalRequestController.getInstance().update(id, txtNoteFire.Text, "Accepted");
                MessageBox.Show("Success accepted the request!");
            }
            txtNoteFire.Clear();
            Load();
        }

        private void btnRejFire_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Reject Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNoteFire.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                PersonalRequestController.getInstance().update(id, txtNoteFire.Text, "Rejected");
                MessageBox.Show("Success rejected the request!");
            }
            txtNoteFire.Clear();
            Load();
        }

        private void btnAccIdea_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Accept Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNoteIdea.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                IdeaController.getInstance().update(id, txtNoteIdea.Text, "Accepted");
                MessageBox.Show("Success accepted the Idea!");
            }
            txtNoteIdea.Clear();
            Load();
        }

        private void btnRejIdea_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Reject Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (txtNoteIdea.Text == "")
            {
                MessageBox.Show("Note must be inputted!");
                return;
            }

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                IdeaController.getInstance().update(id, txtNoteIdea.Text, "Rejected");
                MessageBox.Show("Success rejected the Idea!");
            }
            txtNoteIdea.Clear();
            Load();
        }
    }
}
