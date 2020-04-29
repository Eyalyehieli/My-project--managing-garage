using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static void InsertSupplierDL(string FirstName, string LastName, string Country, string PhoneNumber,
            string Email, string Notes, string Address)
        {
            db.supplierTable.Add(new supplierTable
            {
                firstName = FirstName,
                lastName = LastName,
                country = Country,
                phoneNumber = PhoneNumber,
                E_mail = Email,
                notes = Notes,
                address = Address
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

        public static void UpdateSupplierDL(supplierTable st, string FirstName, string LastName, string Country,
            string PhoneNumber, string Email, string Notes, string Address)
        {
            supplierTable selected_supplier = st;
            selected_supplier.firstName = FirstName;
            selected_supplier.lastName = LastName;
            selected_supplier.country = Country;
            selected_supplier.phoneNumber = PhoneNumber;
            selected_supplier.E_mail = Email;
            selected_supplier.notes = Notes;
            selected_supplier.address = Address;
            db.SaveChanges();
        }

        public static orderFromSupplierDetailTable AddOrderFromSupplier(string name, string type, int amount, int price,
            supplierTable selectedSupplier, string notes)
        {
            orderFromSupplierDetailTable ofsdt=db.orderFromSupplierDetailTable.Add(new orderFromSupplierDetailTable()
            {
                amount = amount,
                notes = notes,
                active = 0,
                name = name,
                materialType = type,
                price = price,
                supplier_id = selectedSupplier.Id,
                supplierTable=selectedSupplier
            });
            db.SaveChanges();
            return ofsdt;
        }

        public static void AddPurchaseFromSupplier(string shippingNumber, string receptionNumber, EmployeeTable employee,
            DateTime orderDate, DateTime supplyingDate, string notes, List<orderFromSupplierDetailTable> Idlist)
        {
            orderFromSupplierTable ofst=db.orderFromSupplierTable.Add(new orderFromSupplierTable()
            {
               shippingNumber = shippingNumber,
               receptionNumber = receptionNumber,
               employee_id = employee.Id,
               EmployeeTable=employee,
               orderDate = orderDate,
               supplyingDate = supplyingDate,
               notes=notes,
               active=0
            });
            db.SaveChanges();
            foreach (orderFromSupplierDetailTable element in Idlist)
            {
                element.orderFromSupplier_id = ofst.Id;
            }
            db.SaveChanges();
        }

        public static void AddPurchaseCostumer(string shippingNumber, string receptionNumber, EmployeeTable employee,
            DateTime orderDste, DateTime supplyingDate, string notes, string shippingAddress,
            List<orderDetailsTable> Idlist)
        {
            OrdersTable ot = db.OrdersTable.Add(new OrdersTable()
            {
                shipping_number = shippingNumber,
                reception_number = receptionNumber,
                employee_id = employee.Id,
                EmployeeTable=employee,
                orderDate = orderDste,
                supplyingDate = supplyingDate,
                notes = notes,
                active = 0,
                shippingAddress = shippingAddress
            });
            db.SaveChanges();
            foreach (orderDetailsTable element in Idlist)
            {
                element.orders_id = ot.Id;
            }
            db.SaveChanges();

        }
        

        public static orderDetailsTable AddCostumerOrder(int discount, int amount, string notes, int active, string name,
            string type, string typeOfTree, string color, string shoeing, int cost, int costPrice,
            CostumersTable selectedCostumer)
        {
             orderDetailsTable odt =db.orderDetailsTable.Add(new orderDetailsTable()
            {
                CostumersTable = selectedCostumer,
                discount = discount,
                amount = amount,
                notes = notes,
                active = active,
                name = name,
                type = type,
                typeOfTree = typeOfTree,
                color = color,
                shoeing = shoeing,
                cost = cost,
                costPrice = costPrice,
                costumers_id = selectedCostumer.Id
            });
            db.SaveChanges();
            return odt;

        }

        public static void UpdateOrderFromSupplierDetail(string materialName, string materialType,
            int amount, int price,
            supplierTable selectedItem,orderFromSupplierDetailTable selectedOrder,int activity,string notes)
        {
            orderFromSupplierDetailTable ofsdt = selectedOrder;
            ofsdt.name = materialName;
            ofsdt.materialType = materialType;
            ofsdt.amount = amount;
            ofsdt.price = price;
            ofsdt.supplierTable = selectedItem;
            ofsdt.orderFromSupplier_id = selectedOrder.Id;
            ofsdt.active = activity;
            ofsdt.notes = notes;
            db.SaveChanges();
        }

        public static void UpdateCostumerOrder(int discount, int amount, string notes, int active, string name,
            string type, string typeOfTree, string color, string shoeing, int cost, int cosPrice,
            CostumersTable selectedCostumer, orderDetailsTable selectedOrder)
        {
            orderDetailsTable odt = selectedOrder;
            odt.discount = discount;
            odt.amount = amount;
            odt.notes = notes;
            odt.active = active;
            odt.name = name;
            odt.type = type;
            odt.typeOfTree = typeOfTree;
            odt.color = color;
            odt.shoeing = shoeing;
            odt.cost = cost;
            odt.costPrice = cosPrice;
            odt.CostumersTable = selectedCostumer;
            odt.costumers_id = selectedCostumer.Id;
            db.SaveChanges();
        }

        public static void UpdatePurchaseFromSupplier(orderFromSupplierTable selectedOrder, string shippingNumber, string receptionNumber,
            EmployeeTable selectedEmployee, DateTime orderDate, DateTime supplyingDate, string notes, int active)
        {
            selectedOrder.shippingNumber = shippingNumber;
            selectedOrder.receptionNumber = receptionNumber;
            selectedOrder.EmployeeTable = selectedEmployee;
            selectedOrder.orderDate = orderDate;
            selectedOrder.supplyingDate = supplyingDate;
            selectedOrder.employee_id = selectedEmployee.Id;
            selectedOrder.notes = notes;
            selectedOrder.active = active;
            db.SaveChanges();
        }

        public static void UpdatePurchaseCostumer(OrdersTable selectedOrder, string shippingNumber,
            string receptionNumber, EmployeeTable selectedEmployee, DateTime orderDate, DateTime supplyingDate,
            string notes, int active, string shippingAddress)
        {
            selectedOrder.shipping_number = shippingNumber;
            selectedOrder.reception_number = receptionNumber;
            selectedOrder.employee_id = selectedEmployee.Id;
            selectedOrder.EmployeeTable = selectedEmployee;
            selectedOrder.orderDate = orderDate;
            selectedOrder.supplyingDate = supplyingDate;
            selectedOrder.notes = notes;
            selectedOrder.active = active;
            selectedOrder.shippingAddress = shippingAddress;
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

        public static IList<supplierTable> GetAllSupplierDL()

        {
            return db.supplierTable.ToList();
        }

        public static IList<orderFromSupplierDetailTable> GetAllOrderFromSupplierDetailDL()
        {
            return db.orderFromSupplierDetailTable.ToList();
        }

        public static IList<orderFromSupplierTable> GetAllOrderFromSupplierDL()
        {
            return db.orderFromSupplierTable.ToList();
        }

        public static IList<orderDetailsTable> GetAllOrderDetailDL()
        {
            return db.orderDetailsTable.ToList();
        }

        public static IList<OrdersTable> GetAllOrderTableDL()
        {
            return db.OrdersTable.ToList();
        }
    }
}
