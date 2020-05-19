using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddCurrentExpend.xaml
    /// </summary>
    public partial class AddCurrentExpend : Window
    {
        EmployeesBL employeeBL =new EmployeesBL();
        public AddCurrentExpend()
        {
            InitializeComponent();
            employeeSlelctionComboBox.ItemsSource = employeeBL.GetAll();
            employeeSlelctionComboBox.DisplayMemberPath = "full_Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //CultureInfo enUS = new CultureInfo("en-US");
           //DateTime myDateTime = DateTime.Parse(date_txb.Text);
            //Expends.AddCurrentExpend((EmployeeTable)employeeSlelctionComboBox.SelectedItem, notes_txb.Text, name_txb.Text, Convert.ToInt32(cost_txb.Text), DateTime.ParseExact(date_txb.Text, "g", enUS, DateTimeStyles.AdjustToUniversal));
            Expends.AddCurrentExpend((EmployeeTable)employeeSlelctionComboBox.SelectedItem, notes_txb.Text, name_txb.Text, Convert.ToInt32(cost_txb.Text), Convert.ToDateTime(date_picker.Text));
            this.Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
