using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CostumersBL
    {
        private managingDataBaseEntities db = new managingDataBaseEntities();
        public static void InsertBL(string firstName, string lastName, string address, string phone, string eMail,int activity,string notes)
        {
            DataLayer.InsertCostumerDL(firstName, lastName, address, phone, eMail,activity,notes);
        }

        public static void UpdateBL(CostumersTable ct, string firstName, string lastName, string address, string phone, string mail, int active)
        {
          DataLayer.UpdateCostumerDL(ct, firstName, lastName, address, phone, mail, active);
        }

        public IList<CostumersTable> GetAll()
        {
           return DataLayer.GetAllCostumersDL();
        }
    }
}
   //yhuyhuy