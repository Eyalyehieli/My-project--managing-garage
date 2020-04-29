using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PurchasingCotumer
    {
        public static void AddPurchaseCostumer(string shippingNumber, string receptionNumber, EmployeeTable employee,
            DateTime orderDate, DateTime supplyingDate, string notes, List<orderDetailsTable> Idlist,string shippingAddress)
        {
            DataLayer.AddPurchaseCostumer(shippingNumber, receptionNumber, employee, orderDate, supplyingDate, notes,shippingAddress,Idlist);
        }

        public static void UpdatePurchaseCostumerBL(OrdersTable selectedOrder, string shippingNumber,
            string receptionNumber, EmployeeTable selectedEmployee, DateTime orderDate, DateTime supplyingDate,
            string notes, int active, string shippingAddress)
        {
            DataLayer.UpdatePurchaseCostumer(selectedOrder,shippingNumber,receptionNumber,selectedEmployee,orderDate,supplyingDate,notes,active,shippingAddress);
        }

        public IList<OrdersTable> GetAll()
        {
            return DataLayer.GetAllOrderTableDL();
        }
    }
}
