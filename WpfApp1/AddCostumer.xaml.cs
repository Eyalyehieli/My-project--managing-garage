using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddCostumer.xaml
    /// </summary>
    public partial class AddCostumer : Window
    {
       managingDataBaseEntities db = new managingDataBaseEntities();
       
        public AddCostumer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CostumersBL.InsertBL(tb_firstName.Text, tb_lasrName.Text, tb_address.Text, tb_phone.Text, tb_mail.Text,0,tb_notes.Text);
            this.Close();
           
        }

        private bool IsValidEmailAddress(string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }

        private void EmailValidationTextBox(object sender, EventArgs e)
        {
            bool result = IsValidEmailAddress(tb_mail.Text);
        }
    }
}
