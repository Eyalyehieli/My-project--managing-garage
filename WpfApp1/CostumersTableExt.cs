using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    partial class CostumersTable
    {
        public string full_Name
        {
            get { return first_Name + " " + last_Name; }
        }
    }

    partial class EmployeeTable
    {
        public string full_Name
        {
            get { return first_Name + " " + last_Name; }
        }
    }
}
