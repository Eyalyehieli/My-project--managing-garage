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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PurchaseCostumer.xaml
    /// </summary>
    public partial class PurchaseCostumer : Window
    {
        private List<orderDetailsTable> Idlist;
        private EmployeesBL employeeBL=new EmployeesBL();
        public PurchaseCostumer(List<orderDetailsTable> Idlist)
        {
            InitializeComponent();
            this.Idlist = Idlist;
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
            this.Close();
        }
    }
}
