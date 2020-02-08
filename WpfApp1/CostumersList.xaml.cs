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
    /// Interaction logic for CostumersList.xaml
    /// </summary>
    public partial class CostumersList : Window
    {
       private CostumersBL customersBL = new CostumersBL();
        public CostumersList()
        {
            InitializeComponent();

            CustomerSelectionComboBox.ItemsSource = customersBL.GetAll();
            CustomerSelectionComboBox.DisplayMemberPath = "full_Name";

        }

       
    }
}
