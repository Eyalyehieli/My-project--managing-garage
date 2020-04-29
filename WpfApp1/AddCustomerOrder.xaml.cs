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
    /// Interaction logic for AddCustomerOrder.xaml
    /// </summary>
    public partial class AddCustomerOrder : Window
    {
        private CostumersBL costumerBL=new CostumersBL();
        private List<orderDetailsTable> idlist; 
        public AddCustomerOrder()
        {
            InitializeComponent();
            CostumerSelectionComboBox.ItemsSource = costumerBL.GetAll();
            CostumerSelectionComboBox.DisplayMemberPath = "full_Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CostumersTable selectedCostumer = (CostumersTable) CostumerSelectionComboBox.SelectedItem;
             orderDetailsTable odt =CostumerOrderBL.AddCostumerOrder(Convert.ToInt32(discount_txb.Text),Convert.ToInt32(amount_txb.Text), notes_txb.Text, 0, productName_txb.Text,
                productType_txb.Text, typeOfTree_txb.Text, color_txb.Text, shoeing_txb.Text,Convert.ToInt32(cost_txb.Text),
               Convert.ToInt32(costPrice_txb.Text), selectedCostumer);

            discount_txb.Text = "";
            amount_txb.Text = "";
            notes_txb.Text = "";
            productName_txb.Text = "";
            productType_txb.Text = "";
            typeOfTree_txb.Text = "";
            color_txb.Text = "";
            shoeing_txb.Text = "";
            cost_txb.Text = "";
            costPrice_txb.Text = "";
            idlist.Add(odt);

            ContinueOrderCostumer coc= new ContinueOrderCostumer(this,this.idlist);
            coc.ShowDialog();

        }
    }
}
