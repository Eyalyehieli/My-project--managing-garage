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
        public static void InsertDL(string firstName, string lastName, string address, string phone, string eMail,int activity,string notes)
        {
            db.CostumersTable.Add(new CostumersTable { first_Name = firstName, last_Name = lastName, address = address, phoneNumber = phone, E_mail = eMail, active = activity,notes = notes});
            db.SaveChanges();
        }        

        public static void UpdateDL(CostumersTable ct,string firstName,string lastName,string address, string phone,string mail, int active)
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
        public static IList<CostumersTable> GetAllDL()
        {
            return db.CostumersTable.ToList();
        }

    }
}
