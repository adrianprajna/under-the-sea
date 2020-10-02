using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using TPA_Desktop.Controller.AttractionDeptController;
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.View.AttractionDeptView
{
    /// <summary>
    /// Interaction logic for AttractionView.xaml
    /// </summary>
    public partial class AttractionView : Window, IView
    {
        Employee employee;
        public AttractionView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            load();
        }

        private void load()
        {
            txtName.Text = "Good to see you back, " + employee.Name + "!";

            viewTransaction.ItemsSource = TicketTransactionController.getInstance().getAll();
            viewTicket.ItemsSource = TicketController.getInstance().getAll();
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

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController.getInstance().viewLogin().Show();
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(txtQty.Text == "")
            {
                MessageBox.Show("Ticket's quantity must be inputted!");
                return;
            }

            int qty;
            bool success = int.TryParse(txtQty.Text, out qty);

            if (success)
            {
                TicketTransactionController.getInstance().add(employee.Id, qty);
                MessageBox.Show("Success add transaction!");
            }
            else
                MessageBox.Show("Quantity must be numeric!");

            txtQty.Clear();
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

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            var ticket = TicketController.getInstance().find(id);

            if (ticket.Valid_Date.ToString().Equals(DateTime.Today.ToString()))
            {
                MessageBox.Show("Valid!");
            }
            else MessageBox.Show("Invalid!");
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            var t = TicketController.getInstance().createTicket();
            TicketController.getInstance().add(t);

            var ticket = TicketController.getInstance().getAll();
            

            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(ticket.LastOrDefault().Id.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);


            Bitmap qrCodeImage = qrCode.GetGraphic(random(50, 150));

            image.Source = BitmapToImageSource(qrCodeImage);

            
            MessageBox.Show("Success generate ticket!");
            load();
        }

        public int random(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private ImageSource BitmapToImageSource(Bitmap bitmap)
        {
            using(MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(txtQty.Text == "")
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            object id_obj = ((Button)sender).CommandParameter;
            int id;
            int.TryParse(id_obj.ToString(), out id);

            int qty;
            bool success = int.TryParse(txtQty.Text, out qty);

            if (success)
            {
                TicketTransactionController.getInstance().update(id, qty);
                MessageBox.Show("Success update transaction!");
            }
            else
                MessageBox.Show("Quantity must be numeric!");

            txtQty.Clear();
            load();
        }
    }
}
