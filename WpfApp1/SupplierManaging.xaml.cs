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
    /// Interaction logic for SupplierManaging.xaml
    /// </summary>
    public partial class SupplierManaging : Window
    {
        public SupplierManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddSupplier asl  = new AddSupplier();
            asl.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SupplierList sl=new SupplierList();
            sl.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SupplierUpdating su=new SupplierUpdating();
            su.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            supplierEmailSending ses=new supplierEmailSending();
            ses.ShowDialog();
        }




       
    }
}
