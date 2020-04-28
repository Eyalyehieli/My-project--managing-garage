using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PurchasingFromSupplierBL
    {
        public static void AddPurchaseFromSupplier(string shippingNumber, string receptionNumber, EmployeeTable employee,
            DateTime orderDate, DateTime supplyingDate, string notes,List<orderFromSupplierDetailTable> Idlist)
        {
            DataLayer.AddPurchaseFromSupplier(shippingNumber, receptionNumber, employee, orderDate, supplyingDate, notes, Idlist);
        }

        public static void UpdateBL(orderFromSupplierTable selectedOrder, string shippingNumber, string receptionNumber,
            EmployeeTable selectedEmployee, DateTime orderDate, DateTime supplyingDate, string notes, int active)
        {
            DataLayer.UpdatePurchaseFromSupplier(selectedOrder,shippingNumber,receptionNumber,selectedEmployee,orderDate,supplyingDate,notes,active);
        }

        public IList<orderFromSupplierTable> GetAll()
        {
            return DataLayer.GetAllOrderFromSupplierDL();
        }
    }
}
