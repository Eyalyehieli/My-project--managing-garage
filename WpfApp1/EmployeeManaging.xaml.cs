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
    /// Interaction logic for EmployeeManaging.xaml
    /// </summary>
    public partial class EmployeeManaging : Window
    {
        public EmployeeManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeesList el= new EmployeesList();
            el.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddEmployee ae= new AddEmployee();
            ae.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           EmployeeUpdaing eu=new EmployeeUpdaing();
            eu.ShowDialog();
        }
    }
}
