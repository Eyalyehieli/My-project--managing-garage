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
    /// Interaction logic for ContinueOrderCostumer.xaml
    /// </summary>
    public partial class ContinueOrderCostumer : Window
    {
        private AddCustomerOrder windowAddCostumerOrder;
        private List<orderDetailsTable> Idlist;
        public ContinueOrderCostumer(AddCustomerOrder window,List<orderDetailsTable> Idlist)
        {
            InitializeComponent();
            this.windowAddCostumerOrder = window;
            this.Idlist = Idlist;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            windowAddCostumerOrder.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PurchaseCostumer pc=new PurchaseCostumer(this.Idlist);
            pc.ShowDialog();

        }


    }
}
