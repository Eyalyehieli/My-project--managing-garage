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
    /// Interaction logic for VariableExpendsManaging.xaml
    /// </summary>
    public partial class VariableExpendsManaging : Window
    {
        public VariableExpendsManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddVariableExpend ave=new AddVariableExpend();
            ave.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateVariableExpend uve=new UpdateVariableExpend();
            uve.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            VariableExpendsList vel=new VariableExpendsList();
            vel.ShowDialog();
        }
    }
}
