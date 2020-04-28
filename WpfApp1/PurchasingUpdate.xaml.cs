﻿using System;
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
    /// Interaction logic for PurchasingUpdate.xaml
    /// </summary>
    public partial class PurchasingUpdate : Window
    {
        private EmployeesBL employeeBL;
        private PurchasingFromSupplierBL purchasingFromSupplierBL;
        public PurchasingUpdate()
        {
            InitializeComponent();
            EmployeeSelectionComboBox.ItemsSource = employeeBL.GetAll();
            EmployeeSelectionComboBox.DisplayMemberPath = "full_Name";
            purchasingUpdateComboBox.ItemsSource = purchasingFromSupplierBL.GetAll();
            purchasingUpdateComboBox.DisplayMemberPath = "Id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            orderFromSupplierTable selectedOrder = (orderFromSupplierTable) purchasingUpdateComboBox.SelectedItem;
            EmployeeTable selectedEmployee = (EmployeeTable) EmployeeSelectionComboBox.SelectedItem;
            PurchasingFromSupplierBL.UpdateBL(selectedOrder,shippingNumber_txb.Text,receptoionNumber_txb.Text,selectedEmployee,DateTime.Parse(OrderDate_txb.Text),DateTime.Parse(supplyingDate_txb.Text),notes_txb.Text,Convert.ToInt32(activity_txb.Text));
        }

        private void EmployeeSelectionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeeTable selectedEmployee = (EmployeeTable) EmployeeSelectionComboBox.SelectedItem;
            if (selectedEmployee.full_Name != employee_txb.Text)
            {
                employee_txb.Text = selectedEmployee.full_Name;
            }
        }


    }
}
