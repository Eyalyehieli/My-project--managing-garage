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
    /// Interaction logic for customerOrderManaging.xaml
    /// </summary>
    public partial class customerOrderManaging : Window
    {
        public customerOrderManaging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerOrder aco=new AddCustomerOrder();
            aco.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomerOrderList col=new CustomerOrderList();
            col.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UpdateOrderOfCustomer uoos=new UpdateOrderOfCustomer();
            uoos.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PurchasecostumerList pcl=new PurchasecostumerList();
            pcl.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            UpdatePurchaseOfCostumer upoc=new UpdatePurchaseOfCostumer();
            upoc.ShowDialog();
        }
    }
}
