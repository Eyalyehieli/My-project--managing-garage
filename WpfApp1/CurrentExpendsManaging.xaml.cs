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
    /// Interaction logic for CurrentExpendsManaging.xaml
    /// </summary>
    public partial class CurrentExpendsManaging : Window
    {
        public CurrentExpendsManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCurrentExpend ace=new AddCurrentExpend();
            ace.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateCurrentExpend uce=new UpdateCurrentExpend();
            uce.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CurrentExpendsList cel=new CurrentExpendsList();
            cel.ShowDialog();
        }
    }
}
