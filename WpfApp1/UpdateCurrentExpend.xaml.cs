using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for UpdateCurrentExpend.xaml
    /// </summary>
    public partial class UpdateCurrentExpend : Window
    {
        EmployeesBL employeeBL =new EmployeesBL();
        public UpdateCurrentExpend()
        {
            InitializeComponent();
            selectionCurrentExpendComboBox.ItemsSource = Expends.GetAllCurentExp();
            selectionCurrentExpendComboBox.DisplayMemberPath = "Id";
            employeeSlelctionComboBox.ItemsSource = employeeBL.GetAll();
            employeeSlelctionComboBox.DisplayMemberPath = "full_Name";
        }

        private void employeeSlelctionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeeTable selectedEmployee = (EmployeeTable)employeeSlelctionComboBox.SelectedItem;
            if (selectedEmployee.full_Name != employeeName_txb.Text)
            {
                employeeName_txb.Text = selectedEmployee.full_Name;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Expends.UpdateCurrentExpend((CurrentExpendsTable)selectionCurrentExpendComboBox.SelectedItem, (EmployeeTable)employeeSlelctionComboBox.SelectedItem, notes_txb.Text, name_txb.Text, Convert.ToInt32(cost_txb.Text), Convert.ToDateTime(date_Picker.Text), Convert.ToInt32(active_txb.Text));
            this.Close();
        }

    }
}
