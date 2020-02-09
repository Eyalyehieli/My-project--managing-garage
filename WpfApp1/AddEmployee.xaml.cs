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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        managingDataBaseEntities db = new managingDataBaseEntities();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeesBL.InsertBL(tb_firstName.Text, tb_lasrName.Text, tb_address.Text, tb_phone.Text, tb_mail.Text, 0, tb_notes.Text,Convert.ToInt32(tb_salary.Text));
            this.Close();
        }
    }
}
