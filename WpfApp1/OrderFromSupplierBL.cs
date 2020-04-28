using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class OrderFromSupplierBL
    {
        public static orderFromSupplierDetailTable AddOrderFromSupllier(string name, string type, int amount, int price, supplierTable selectedSupplier,string notes)
        {
           orderFromSupplierDetailTable ofsdt= DataLayer.AddOrderFromSupplier(name, type, amount, price, selectedSupplier,notes);
            return ofsdt;
        }
        public IList<orderFromSupplierDetailTable> GetAll()
        {
            return DataLayer.GetAllOrderFromSupplierDetailDL();
        }

        public static void UpdateBL (string materialName, string materialType, int amount, int price,
            supplierTable selectedItem,orderFromSupplierDetailTable selectedOrder,int activity,string notes)
        {
            DataLayer.UpdateOrderFromSupplierDetail(materialName,materialType,amount,price,selectedItem,selectedOrder,activity,notes);
        }
    }
}
