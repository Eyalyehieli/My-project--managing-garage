using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class EmployeesBL
    {
        public static void InsertBL(string firstName, string lastName, string address, string phone, string eMail,
            int activity, string notes, int salary)
        {
            DataLayer.InsertEmployeeDL(firstName,lastName,address,phone,eMail,activity,notes,salary);
        }

        public static void UpdateBL(EmployeeTable et, string firstName, string lastName, string address, string phone,
            string mail, int active, int salary)
        {
           DataLayer.UpdateEmployeeDL(et,firstName,lastName,address,phone,mail,active,salary);
        }
        public IList<EmployeeTable> GetAll()
        {
            return DataLayer.GetAllEmployeesDL();
        }
    }
}
