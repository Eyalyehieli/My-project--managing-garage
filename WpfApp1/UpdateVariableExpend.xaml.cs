using System;
using System.Collections.Generic;
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
    /// Interaction logic for UpdateVariableExpend.xaml
    /// </summary>
    public partial class UpdateVariableExpend : Window
    {
        EmployeesBL employeeBL=new EmployeesBL();
    
        public UpdateVariableExpend()
        {
            InitializeComponent();
            selectionVarialeExpendComboBox.ItemsSource = Expends.GetAllVariableExp();
            selectionVarialeExpendComboBox.DisplayMemberPath = "Id";
            employeeSlelctionComboBox.ItemsSource = employeeBL.GetAll();
            employeeSlelctionComboBox.DisplayMemberPath = "full_Name";
           
        }
        private void employeeSlelctionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeeTable selectedEmployee = (EmployeeTable) employeeSlelctionComboBox.SelectedItem;
            if (selectedEmployee.full_Name != employeeName_txb.Text)
            {
                employeeName_txb.Text = selectedEmployee.full_Name;
            }
            
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeTable selectedEmployee=new EmployeeTable();
           
            selectedEmployee = (EmployeeTable) employeeSlelctionComboBox.SelectedItem;
           
            Expends.UpdateVariableExpend((variableExpendsTable)selectionVarialeExpendComboBox.SelectedItem,selectedEmployee,notes_txb.Text,name_txb.Text,Convert.ToInt32(cost_txb.Text),Convert.ToDateTime(date_picker.Text),Convert.ToInt32(active_txb.Text));
            this.Close();
        }


    }
}
