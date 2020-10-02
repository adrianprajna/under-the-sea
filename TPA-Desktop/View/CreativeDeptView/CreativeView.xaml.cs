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
using TPA_Desktop.Controller.ConstructionDeptController;
using TPA_Desktop.Controller.CreativeDeptController;
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View
{
    /// <summary>
    /// Interaction logic for CreativeView.xaml
    /// </summary>
    public partial class CreativeView : Window, IView
    {
        Employee employee;

        public CreativeView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        public void show()
        {
            txtName.Text = "Good to see you back, " + employee.Name + "!";
            Show();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        public void load()
        {
            List<PurchaseRequest> reqs = PurchaseRequestController.getInstance().getAll();
            List<Idea> ideas = IdeaController.getInstance().getAll();
            List<FundRequest> funds = FundRequestController.getInstance().getAll();
            List<Construction> cons = ConstructionController.getInstance().getAll();
            List<PersonalRequest> pers_reqs = PersonalRequestController.getInstance().getAll();

            var pers_status = pers_reqs.Where(p => p.EmployeeID == employee.Id && (p.Status == "Accepted" ||                                        p.Status == "Rejected"));

            var cons_status = cons.Where(c => c.Status == "In progress of constructing" || c.Status == "Finish constructing");

            var funds_status = funds.Where(p => (p.Status == "Accepted" || p.Status == "Rejected") &&
                                            p.DepartmentId == employee.DepartmentID);

            var idea_status = ideas.Where(i => i.Status == "Accepted" || i.Status == "Rejected");
            
            var req_status = reqs.Where(p => (p.Status == "Accepted" || p.Status == "Rejected") &&
                                            p.DepartmentId == employee.DepartmentID);

            var req_filtered = req_status.Select(p => new
            {
                p.Id,
                p.Information,
                p.Note,
                p.Status,
                p.Date
            });

            var cons_filtered = cons_status.Select(c => new
            {
                c.Id,
                title = c.Idea.Tittle,
                information = c.Idea.Information,
                c.Status
            });

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

            viewFund.ItemsSource = funds_status;
            viewPurchase.ItemsSource = req_filtered;
            viewIdeas.ItemsSource = idea_status;
            viewCons.ItemsSource = cons_filtered;
            viewRA.ItemsSource = AttractionRideController.getInstance().getAll();
            viewPers.ItemsSource = pers_filterd;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            if (IdeaController.getInstance().send(id) == 1)
                MessageBox.Show("Success send to construction!");

            else if (IdeaController.getInstance().send(id) == 0)
                MessageBox.Show("The idea has been sent!");

            else
                MessageBox.Show("The idea must be accepted!");


            load();
        }

        private void btnPropose_Click(object sender, RoutedEventArgs e)
        {
            bool success = false;
            string title = txtTitle.Text;
            string information = txtInformation.Text;

            if (title == "" || information == "")
            {
                MessageBox.Show("Invalid Input!");
                reset();
                return;
            }

            success = IdeaController.getInstance().insert(title, information);
            if(success)
                MessageBox.Show("Success propose the idea!");
           
            else
                MessageBox.Show("Error occured!");

            load();
            reset();
        }

        private void reset()
        {
            txtInformation.Text = "";
            txtTitle.Text = "";
        }

        private void btnAddRA_Click(object sender, RoutedEventArgs e)
        {
            if (txtRAName.Text == "" || txtRADescription.Text == "")
            {
                MessageBox.Show("Invalid Input!");
                reset();
                return;
            }

            if (btnRide.IsChecked == true)
            {
                AttractionRideController.getInstance().add(txtRAName.Text, txtRADescription.Text, "Ride");
                MessageBox.Show("Success add new ride!");
            }
                

            else
            {
                AttractionRideController.getInstance().add(txtRAName.Text, txtRADescription.Text, "Attraction");
                MessageBox.Show("Success add new attraction!");
            }

            reset();
            load();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            AttractionRideController.getInstance().viewUpdate(id).Show();
            load();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);


            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);

            if (messageBoxResult == MessageBoxResult.Yes)
                if (AttractionRideController.getInstance().remove(id))
                    MessageBox.Show("Success remove the data!");
                else
                    MessageBox.Show("Only active attraction or ride that can be removed!");



            load();
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {
            if(txtPurchase.Text == "")
            {
                MessageBox.Show("Invalid Input!");
                return;
            }

            PurchaseRequestController.getInstance().add((int)employee.DepartmentID, txtPurchase.Text);
            MessageBox.Show("Success request for purchase!");
            txtPurchase.Clear();
        }

        private void btnFund_Click(object sender, RoutedEventArgs e)
        {
            if(txtFund.Text == "" || txtMoney.Text == "")
            {
                MessageBox.Show("Invalid Input");
                return;
            }

            int money;
            bool success = int.TryParse(txtMoney.Text, out money);

            if (success)
            {
                FundRequestController.getInstance().add((int)employee.DepartmentID, txtFund.Text, money);
                MessageBox.Show("Success request for fund!");
                txtFund.Clear();
                txtMoney.Clear();
            }
            else MessageBox.Show("Money must be numeric");
            
        }

        private void btnPersonal_Click(object sender, RoutedEventArgs e)
        {
            if(txtDescPersonal.Text == "" || txtTitlePersonal.Text == "")
            {
                MessageBox.Show("Invalid Input");
                return;
            }
            
            if(btnLeaving.IsChecked == true)
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
