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
    /// Interaction logic for UpdateOrderOfCustomer.xaml
    /// </summary>
    public partial class UpdateOrderOfCustomer : Window
    {
        private CostumersBL cotumerBL=new CostumersBL();
        private CostumerOrderBL orderDetailBL=new CostumerOrderBL();
        public UpdateOrderOfCustomer()
        {
            InitializeComponent();
            CostumerSelectionComboBox.ItemsSource = CostumerOrderBL.GetAll();
            CostumerSelectionComboBox.DisplayMemberPath = "full_Name";
            IdOrderSelectionComboBox.ItemsSource = CostumerOrderBL.GetAll();
            IdOrderSelectionComboBox.DisplayMemberPath = "Id";
        }

        private void CostumerSelectionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CostumersTable selectedCostumer = (CostumersTable) CostumerSelectionComboBox.SelectedItem;
            if (selectedCostumer.full_Name != costumerName_txb.Text)
            {
                costumerName_txb.Text = selectedCostumer.full_Name;
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CostumersTable selectedCostumer = (CostumersTable) CostumerSelectionComboBox.SelectedItem;
            orderDetailsTable selectedOrder = (orderDetailsTable) IdOrderSelectionComboBox.SelectedItem;
            CostumerOrderBL.UpdateBL(Convert.ToInt32(discount_txb.Text), Convert.ToInt32(amount_txb.Text),
                notes_txb.Text, Convert.ToInt32(active_txb.Text), productName_txb.Text, productType_txb.Text,
                typeOfTree_txb.Text, color_txb.Text, shoeing_txb.Text, Convert.ToInt32(cost_txb.Text),
                Convert.ToInt32(costPrice_txb.Text), selectedCostumer, selectedOrder);
            this.Close();
        }

    }
}
