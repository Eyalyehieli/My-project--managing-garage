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
    /// Interaction logic for PurchaseCostumer.xaml
    /// </summary>
    public partial class PurchaseCostumer : Window
    {
        private List<orderDetailsTable> Idlist;
        private EmployeesBL employeeBL=new EmployeesBL();
        private ContinueOrderCostumer coc;
        public PurchaseCostumer(List<orderDetailsTable> Idlist,ContinueOrderCostumer coc)
        {
            InitializeComponent();
            this.Idlist = Idlist;
            this.coc = coc;
            EmployeeSelectionComboBox.ItemsSource = employeeBL.GetAll();
            EmployeeSelectionComboBox.DisplayMemberPath = "full_Name";
            OrderIdSelectionComboBox.ItemsSource = Idlist;
            OrderIdSelectionComboBox.DisplayMemberPath = "Id";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeTable selectedEmployee = (EmployeeTable) EmployeeSelectionComboBox.SelectedItem;
            PurchasingCotumer.AddPurchaseCostumer(shippingNumber_txb.Text, receptoionNumber_txb.Text, selectedEmployee,
               Convert.ToDateTime(order_datePicker.Text), Convert.ToDateTime(supplying_datePicker.Text), notes_txb.Text, this.Idlist,
                shippingAddress_txb.Text);
            coc.Close();
            this.Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
