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
    /// Interaction logic for AddOrderFromSupplier.xaml
    /// </summary>
    public partial class AddOrderFromSupplier : Window
    {
        private SupplierBL supplierBL=new SupplierBL();
        private List<orderFromSupplierDetailTable> IdList=new List<orderFromSupplierDetailTable>();
        public AddOrderFromSupplier()
        {
            InitializeComponent();
            supplierSelectionComboBox.ItemsSource = supplierBL.GetAll();
            supplierSelectionComboBox.DisplayMemberPath = "full_Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             supplierTable selectedSupplier =(supplierTable)supplierSelectionComboBox.SelectedItem;
           orderFromSupplierDetailTable id= OrderFromSupplierBL.AddOrderFromSupllier(name_txb.Text, type_txb.Text,Convert.ToInt32(amount_txb.Text),Convert.ToInt32(price_txb.Text),
            selectedSupplier,notes_txb.Text);

            name_txb.Text = "";
            type_txb.Text = "";
            price_txb.Text = "";
            notes_txb.Text = "";
            amount_txb.Text = "";
            IdList.Add(id);
            ContinueOrderingMessage com =new ContinueOrderingMessage(this,this.IdList);
            this.Hide();
            com.ShowDialog();

        }
    }
}
