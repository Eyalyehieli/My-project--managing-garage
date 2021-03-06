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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CostumersManaging cm = new CostumersManaging();
            cm.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeeManaging em=new EmployeeManaging();
            em.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SupplierManaging sm=new SupplierManaging();
           sm.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ordersType ot = new ordersType();
            ot.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ExpenseAndReportsManaging ear=new ExpenseAndReportsManaging();
            ear.ShowDialog();
        }
    }
}
