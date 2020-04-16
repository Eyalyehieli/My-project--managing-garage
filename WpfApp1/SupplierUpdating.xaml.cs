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
    /// Interaction logic for SupplierUpdating.xaml
    /// </summary>
    public partial class SupplierUpdating : Window
    {
        private SupplierBL supplierBL=new SupplierBL();
        public SupplierUpdating()
        {
           InitializeComponent();
           SupllierSelectionComboBox.ItemsSource = supplierBL.GetAll();
           SupllierSelectionComboBox.DisplayMemberPath = "full_Name";
        }

        


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private bool IsValidEmailAddress(string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }

        private void EmailValidationTextBox(object sender, EventArgs e)
        {
            bool result = IsValidEmailAddress(Email_txb.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            supplierTable selected_supplier = (supplierTable) SupllierSelectionComboBox.SelectedItem;
            SupplierBL.UpdateBL(selected_supplier,firstName_txb.Text,lastName_txb.Text,country_txb.Text,phone_txb.Text,Email_txb.Text,Notes_txb.Text,address_txb.Text);
            this.Close();
        }
    }
}
