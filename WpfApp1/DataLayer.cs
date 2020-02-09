using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DataLayer
    {
        private static managingDataBaseEntities db = new managingDataBaseEntities();
        public static void InsertCostumerDL(string firstName, string lastName, string address, string phone, string eMail,int activity,string notes)
        {
            db.CostumersTable.Add(new CostumersTable { first_Name = firstName, last_Name = lastName, address = address, phoneNumber = phone, E_mail = eMail, active = activity,notes = notes});
            db.SaveChanges();
        }

        public static void InsertEmployeeDL(string firstName, string lastName, string address, string phone,
            string eMail, int activity, string notes, int salary)
        {
            db.EmployeeTable.Add(new EmployeeTable
            {
                first_Name = firstName,
                last_Name = lastName,
                address = address,
                phoneNumber = phone,
                E_mail = eMail,
                active = activity,
                notes = notes,
                salary = salary
            });
            db.SaveChanges();
        }

        public static void UpdateCostumerDL(CostumersTable ct,string firstName,string lastName,string address, string phone,string mail, int active)
        {
            CostumersTable selected_costumer = ct;
            selected_costumer.first_Name = firstName;
            selected_costumer.last_Name= lastName;
            selected_costumer.address = address;
            selected_costumer.phoneNumber = phone;
            selected_costumer.E_mail =mail;
            selected_costumer.active = active;
            db.SaveChanges();
        }

        public static void UpdateEmployeeDL(EmployeeTable et, string firstName, string lastName, string address,
            string phone, string mail, int active, int salary)
        {
            EmployeeTable selected_employee = et;
            selected_employee.first_Name = firstName;
            selected_employee.last_Name = lastName;
            selected_employee.address = address;
            selected_employee.phoneNumber = phone;
            selected_employee.E_mail = mail;
            selected_employee.active = active;
            selected_employee.salary = salary;
            db.SaveChanges();
        }
        public static IList<CostumersTable> GetAllCostumersDL()
        {
            return db.CostumersTable.ToList();
        }

        public static IList<EmployeeTable> GetAllEmployeesDL()
        {
            return db.EmployeeTable.ToList();
        }

    }
}
