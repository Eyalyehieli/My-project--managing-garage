using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Security.Cryptography;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for supplierEmailSending.xaml
    /// </summary>
    public partial class supplierEmailSending : Window
    {
        private SupplierBL supplierBL = new SupplierBL();
        private supplierTable selected_supplier=new supplierTable();

        public supplierEmailSending()
        {
            InitializeComponent();
            supplierEmailSendingComboBox.ItemsSource = supplierBL.GetAll();
            supplierEmailSendingComboBox.DisplayMemberPath = "full_Name";
        }

       

        private void supplierEmailSendingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected_supplier = (supplierTable)supplierEmailSendingComboBox.SelectedItem;
            toLabel.Content = selected_supplier.E_mail;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("lior.yehieli@gmail.com", "Eyal1234");
                MailMessage msg = new MailMessage();
                msg.To.Add(toLabel.Content.ToString());
                msg.From = new MailAddress("lior.yehieli@gmail.com");
                msg.Subject = subjuct_txb.Text;
                msg.Body = body_txb.Text;
                client.Send(msg);
                MessageBox.Show("Successfully sent message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
