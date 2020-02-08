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
    /// Interaction logic for CostumersManaging.xaml
    /// </summary>
    public partial class CostumersManaging : Window
    {
        public CostumersManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCostumer ac = new AddCostumer();
            ac.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CostumerUpdating cu = new CostumerUpdating();
            cu.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CostumersList cl = new CostumersList();
            cl.ShowDialog();
        }
    }
}
