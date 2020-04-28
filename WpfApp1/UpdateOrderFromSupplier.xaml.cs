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
    /// Interaction logic for UpdateOrderFromSupplier.xaml
    /// </summary>
    public partial class UpdateOrderFromSupplier : Window
    {
        private OrderFromSupplierBL orderFromSupplierBL;
        private SupplierBL supplierBL;
        public UpdateOrderFromSupplier()
        {
            InitializeComponent();
            IdNumberComboBox.ItemsSource = orderFromSupplierBL.GetAll();
            IdNumberComboBox.DisplayMemberPath = "Id";
            supplierChangingComboBox.ItemsSource = supplierBL.GetAll();
            supplierChangingComboBox.DisplayMemberPath = "full_Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            orderFromSupplierDetailTable selectedOrder = (orderFromSupplierDetailTable) IdNumberComboBox.SelectedItem;
            supplierTable selectedItem = (supplierTable) supplierChangingComboBox.SelectedItem;
           OrderFromSupplierBL.UpdateBL (materialName.Text, materialType.Text, Convert.ToInt32(amount.Text), Convert.ToInt32(price.Text), selectedItem, selectedOrder, Convert.ToInt32(activity.Text),notes.Text)
            ;
        }

        private void supplierChangingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            supplierTable selectedItem = (supplierTable) supplierChangingComboBox.SelectedItem;
            if (selectedItem.full_Name != supplierName.Text)
            {
                supplierName.Text = selectedItem.full_Name;
            }
        }

      


       
    }
}
