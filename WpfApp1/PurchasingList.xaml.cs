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
    /// Interaction logic for PurchasingList.xaml
    /// </summary>
    public partial class PurchasingList : Window
    {
        private PurchasingFromSupplierBL purchasingFromSupplierBL;
        public PurchasingList()
        {
            InitializeComponent();
            purchasingUpdateComboBox.ItemsSource = purchasingFromSupplierBL.GetAll();
            purchasingUpdateComboBox.DisplayMemberPath = "Id";
        }

    }
}
