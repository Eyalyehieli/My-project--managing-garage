using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CostumerOrderBL
    {
        public static orderDetailsTable AddCostumerOrder(int discount, int amount, string notes, int active, string name,
            string type, string typeOfTree, string color, string shoeing, int cost, int costPrice,
            CostumersTable selectedCostumer)
        {
            orderDetailsTable odt =DataLayer.AddCostumerOrder(discount, amount, notes, active, name, type, typeOfTree, color, shoeing, cost,
                costPrice, selectedCostumer);
            return odt;
        }

        public static void UpdateBL(int discount, int amount, string notes, int active, string name,
            string type, string typeOfTree, string color, string shoeing, int cost, int cosPrice,
            CostumersTable selectedCostumer, orderDetailsTable selectedOrder)
        {
            DataLayer.UpdateCostumerOrder(discount,amount,notes,active,name,type,typeOfTree,color,shoeing,cost,cosPrice,selectedCostumer,selectedOrder);
        }

        public static IList<orderDetailsTable> GetAll()
        {
            return DataLayer.GetAllOrderDetailDL();
        }
    }
}
