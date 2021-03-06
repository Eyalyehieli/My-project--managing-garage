﻿using System;
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
    /// Interaction logic for AddVariableExpend.xaml
    /// </summary>
    public partial class AddVariableExpend : Window
    {
        EmployeesBL employeeBL=new EmployeesBL();
        public AddVariableExpend()
        {
            InitializeComponent();
            employeeSlelctionComboBox.ItemsSource = employeeBL.GetAll();
            employeeSlelctionComboBox.DisplayMemberPath = "full_Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Expends.AddVariableExpend((EmployeeTable)employeeSlelctionComboBox.SelectedItem,notes_txb.Text,name_txb.Text,Convert.ToInt32(cost_txb.Text),Convert.ToDateTime(date_picker.Text));
            this.Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
