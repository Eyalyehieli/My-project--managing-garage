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
    /// Interaction logic for UpdatePurchaseOfCostumer.xaml
    /// </summary>
    public partial class UpdatePurchaseOfCostumer : Window
    {
        private EmployeesBL employeeBL = new EmployeesBL();
        private PurchasingCotumer purchasingCostumerBL = new PurchasingCotumer();
        public UpdatePurchaseOfCostumer()
        {
            InitializeComponent();
            EmployeeSelectionComboBox.ItemsSource = employeeBL.GetAll();
            EmployeeSelectionComboBox.DisplayMemberPath = "full_Name";
            purchasingUpdateComboBox.ItemsSource = purchasingCostumerBL.GetAll();
            purchasingUpdateComboBox.DisplayMemberPath = "Id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrdersTable selectedOrder = (OrdersTable)purchasingUpdateComboBox.SelectedItem;
            EmployeeTable selectedEmployee = (EmployeeTable)EmployeeSelectionComboBox.SelectedItem;
            PurchasingCotumer.UpdatePurchaseCostumerBL(selectedOrder,shippingNumber_txb.Text,receptoionNumber_txb.Text,selectedEmployee,DateTime.Parse(OrderDate_txb.Text),DateTime.Parse(supplyingDate_txb.Text),notes_txb.Text,Convert.ToInt32(activity_txb.Text),shippingAddress_txb.Text);
        }

        private void EmployeeSelectionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeeTable selectedEmployee = (EmployeeTable)EmployeeSelectionComboBox.SelectedItem;
            if (selectedEmployee.full_Name != employee_txb.Text)
            {
                employee_txb.Text = selectedEmployee.full_Name;
            }
        }
    }
}
