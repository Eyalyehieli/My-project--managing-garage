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
    /// Interaction logic for CostumerUpdating.xaml
    /// </summary>
    public partial class CostumerUpdating : Window
    {
        private CostumersBL customersBL = new CostumersBL();
        public CostumerUpdating()
        {
            InitializeComponent();
            CustomerSelectionComboBox.ItemsSource = customersBL.GetAll();
            CustomerSelectionComboBox.DisplayMemberPath = "full_Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            CostumersTable selected_costumer = (CostumersTable)CustomerSelectionComboBox.SelectedItem;
            CostumersBL.UpdateBL(selected_costumer, firstname_txb.Text, lastName_txb.Text, address_txb.Text, phone_txb.Text, mail_txb.Text, Int32.Parse(status_txb.Text));
            this.Close();
            
        }

        private bool IsValidEmailAddress(string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }

        private void EmailValidationTextBox(object sender, EventArgs e)
        {
            bool result = IsValidEmailAddress(mail_txb.Text);
        }
    }
}
