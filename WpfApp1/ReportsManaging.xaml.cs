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
    /// Interaction logic for ReportsManaging.xaml
    /// </summary>
    public partial class ReportsManaging : Window
    {
        public ReportsManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reports.SupplierReport();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reports.EmployeesReport();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Reports.CostumersReport();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Reports.OrderFromSupplierReport();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Reports.PurchasingFromSupplier();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Reports.OrderReport();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Reports.PurchasingReport();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Reports.VarriableExpendsRepors();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Reports.CurrentExpendsReport();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Reports.Profitability();
        }
    }
}
