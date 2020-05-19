using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class SupplierBL
    {
        private managingDataBaseEntities db = new managingDataBaseEntities();

        public static void InsertBL(string FirstName, string LastName, string Country, string PhoneNumber,
            string Email, string Notes, string Address)
        {
            DataLayer.InsertSupplierDL(FirstName,LastName,Country,PhoneNumber,Email,Notes,Address);
        }

        public static void UpdateBL (supplierTable st, string FirstName, string LastName, string Country,
            string PhoneNumber,string Email, string Notes, string Address,string active)
        {
            DataLayer.UpdateSupplierDL(st,FirstName,LastName,Country,PhoneNumber,Email,Notes,Address,active);
        }


        public IList<supplierTable> GetAll()
        {
            return DataLayer.GetAllSupplierDL();
        }
    }
}
