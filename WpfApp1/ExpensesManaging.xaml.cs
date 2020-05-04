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
    /// Interaction logic for ExpensesManaging.xaml
    /// </summary>
    public partial class ExpensesManaging : Window
    {
        public ExpensesManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VariableExpendsManaging vem=new VariableExpendsManaging();
            vem.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CurrentExpendsManaging cem=new CurrentExpendsManaging();
            cem.ShowDialog();
        }
    }
}
