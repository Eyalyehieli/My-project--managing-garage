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
    /// Interaction logic for supplierOrderManaging.xaml
    /// </summary>
    public partial class supplierOrderManaging : Window
    {
        public supplierOrderManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrderFromSupllierList ofsl=new OrderFromSupllierList();
            ofsl.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateOrderFromSupplier uofs=new UpdateOrderFromSupplier();
            uofs.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddOrderFromSupplier aofs=new AddOrderFromSupplier();
            aofs.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PurchasingUpdate pu=new PurchasingUpdate();
            pu.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PurchasingList pl=new PurchasingList();
            pl.ShowDialog();
        }
    }
}
