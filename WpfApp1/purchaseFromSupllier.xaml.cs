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
    /// Interaction logic for purchaseFromSupllier.xaml
    /// </summary>
    public partial class purchaseFromSupllier : Window
    {
        private List<orderFromSupplierDetailTable> Idlist;
        private EmployeesBL employeeBL=new EmployeesBL();
        private ContinueOrderingMessage com;
        public purchaseFromSupllier(List<orderFromSupplierDetailTable> Idlist,ContinueOrderingMessage com)
        {
            InitializeComponent();
            this.Idlist = Idlist;
            this.com = com;
            EmployeeSelectionComboBox.ItemsSource = employeeBL.GetAll();
            EmployeeSelectionComboBox.DisplayMemberPath = "full_Name";
            OrderIdSelectionComboBox.ItemsSource = Idlist;
            OrderIdSelectionComboBox.DisplayMemberPath = "Id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PurchasingFromSupplierBL.AddPurchaseFromSupplier(shippingNumber_txb.Text,receptoionNumber_txb.Text,(EmployeeTable)EmployeeSelectionComboBox.SelectedItem,Convert.ToDateTime(order_datePicker.Text),Convert.ToDateTime(supplying_datePicker.Text),notes_txb.Text,Idlist);
            com.Close();
            this.Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
