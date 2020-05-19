using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Reports
    {
        
        public static void SupplierReport()
        {
            IList<supplierTable> suppliers = DataLayer.GetAllSupplierDL();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח ספקים</title>" + "</head><body><h1>תוצאות דוח ספקים</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>שם מלא</th><th>מדינת מוצא</th><th>מספר טלפון</th><th>מייל</th><th>הערות</th><th>כתובת</th><th>מצב פעילות</th></tr></thead>" +
                          "<tbody>";
            foreach (supplierTable elemant in suppliers)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body+= "<tr><td>"+elemant.Id.ToString()+ "</td><td>"+elemant.full_Name+"</td><td>"+elemant.country+
                    "</td><td>" + elemant.phoneNumber + "</td><td>" + elemant.E_mail + "</td><td>" + elemant.notes + "</td><td>" + elemant.address + "</td><td>" + active.ToString()+ "</td></tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void EmployeesReport()
        {
            IList<EmployeeTable> employees = DataLayer.GetAllEmployeesDL();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח עובדים</title>" + "</head><body><h1>תוצאות דוח עובדים</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>שם מלא</th><th>כתובת</th><th>מספר טלפון</th><th>מייל</th><th>הערות</th><th>שכר</th><th>מצב פעילות</th></tr></thead>" +
                          "<tbody>";
            foreach (EmployeeTable elemant in employees)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body += "<tr><td>" + elemant.Id.ToString() + "</td><td>" + elemant.full_Name + "</td><td>" + elemant.address +
                    "</td><td>" + elemant.phoneNumber + "</td><td>" + elemant.E_mail + "</td><td>" + elemant.notes + "</td><td>" + elemant.salary.ToString() + "</td><td>" + active.ToString() + "</td></tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void CostumersReport()
        {
            IList<CostumersTable> customers = DataLayer.GetAllCostumersDL();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח לקוחות</title>" + "</head><body><h1>תוצאות דוח לקוחות</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>שם מלא</th><th>כתובת</th><th>מספר טלפון</th><th>מייל</th><th>הערות</th><th>מצב פעילות</th></tr></thead>" +
                          "<tbody>";
            foreach (CostumersTable elemant in customers)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body += "<tr><td>" + elemant.Id.ToString() + "</td><td>" + elemant.full_Name + "</td><td>" + elemant.address +
                    "</td><td>" + elemant.phoneNumber + "</td><td>" + elemant.E_mail + "</td><td>" + elemant.notes + "</td><td>" + active.ToString() + "</td></tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void OrderFromSupplierReport()
        {
            IList<orderFromSupplierDetailTable> orderFromSupplier = DataLayer.GetAllOrderFromSupplierDetailDL();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח הזמנות מספק</title>" + "</head><body><h1>תוצאות דוח הזמנות מספק</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>כמות</th><th>הערות</th><th>מצב פעילות</th><th>שם מוצר</th><th>סוג המוצר</th><th>מזהה ספק</th><th>מחיר</th><th>מזהה רכישה</th></tr></thead>" +
                          "<tbody>";
            foreach (orderFromSupplierDetailTable elemant in orderFromSupplier)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body += "<tr><td>" + elemant.Id.ToString() + "</td><td>" + elemant.amount.ToString() + "</td><td>" + elemant.notes +
                    "</td><td>" + active.ToString() + "</td><td>" + elemant.name + "</td><td>" + elemant.materialType + "</td><td>" + elemant.supplier_id.ToString() + "</td><td>" + elemant.price.ToString() + "</td><td>" + elemant.orderFromSupplier_id.ToString() + "</td</tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void PurchasingFromSupplier()
        {
            IList<orderFromSupplierTable> purchaseFromSupplier = DataLayer.GetAllOrderFromSupplierDL();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח רכישה מספק</title>" + "</head><body><h1>תוצאות דוח רכישה מספק</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>מספר משלוח</th><th>מספר קבלה</th><th> מזהה עובד</th><th>תאריך הזמנה</th><th>תאריך הספקה</th><th>הערות</th><th>מצב פעילות</th></tr></thead>" +
                          "<tbody>";
            foreach (orderFromSupplierTable elemant in purchaseFromSupplier)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body += "<tr><td>" + elemant.Id.ToString() + "</td><td>" + elemant.shippingNumber + "</td><td>" + elemant.receptionNumber +
                    "</td><td>" + elemant.employee_id.ToString() + "</td><td>" + elemant.orderDate.ToString() + "</td><td>" + elemant.supplyingDate.ToString() + "</td><td>" + elemant.notes + "</td><td>" + active.ToString() + "</td></tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void OrderReport()
        {
            IList<orderDetailsTable> orders = DataLayer.GetAllOrderDetailDL();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח הזמנות של לקוחות</title>" + "</head><body><h1>תוצאות דוח הזמנות של לקוחות</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>הנחה</th><th>כמות</th><th>הערות</th><th>מצב פעילות</th><th>שם מוצר</th><th>סוג מוצר</th><th>סוג עץ</th><th>צבע</th><th>פרזול</th><th>מחיר</th><th>מחיר עלות</th><th>מזהה רכישה</th><th>מזהה לקוח</th></tr></thead>" +
                          "<tbody>";
            foreach (orderDetailsTable elemant in orders)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body += "<tr><td>" + elemant.Id.ToString() + "</td><td>" + elemant.discount.ToString() + "</td><td>" + elemant.amount.ToString() +
                    "</td><td>" + elemant.notes+ "</td><td>" + active.ToString() + "</td><td>" + elemant.name + "</td><td>" + elemant.type + "</td><td>" + elemant.typeOfTree + "</td><td>" + elemant.color + "</td<td>" + elemant.shoeing + "</td<td>" + elemant.cost.ToString() + "</td<td>" + elemant.costPrice.ToString() + "</td<td>" + elemant.orders_id.ToString() + "</td<td>" + elemant.costumers_id.ToString() + "</td</tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void PurchasingReport()
        {
            IList<OrdersTable> orders = DataLayer.GetAllOrderTableDL();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח רכישה של לקוחות</title>" + "</head><body><h1>תוצאות דוח רכישה של לקוחות</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>מספר משלוח</th><th>מספר קבלה</th><th> מזהה עובד</th><th>תאריך הזמנה</th><th>תאריך הספקה</th><th>הערות</th><th>מצב פעילות</th><th>כתובת לשליחה</th></tr></thead>" +
                          "<tbody>";
            foreach (OrdersTable elemant in orders)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body += "<tr><td>" + elemant.Id.ToString() + "</td><td>" + elemant.shipping_number + "</td><td>" + elemant.reception_number +
                    "</td><td>" + elemant.employee_id.ToString() + "</td><td>" + elemant.orderDate.ToString() + "</td><td>" + elemant.supplyingDate.ToString() + "</td><td>" + elemant.notes + "</td><td>" + active.ToString() + "</td><td>" + elemant.shippingAddress + "</td></tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void CurrentExpendsReport()
        {
            IList<CurrentExpendsTable> currentExpends = DataLayer.GetAllCurrentExpends();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח הוצאות שוטפות</title>" + "</head><body><h1>תוצאות דוח הוצאות שוטפות</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>מזהה עובד</th><th>הערות</th><th>מצב פעילות</th><th>שם ההוצאה</th><th>עלות ההוצאה</th><th>תאריך ההוצאה</th></tr></thead>" +
                          "<tbody>";
            foreach (CurrentExpendsTable elemant in currentExpends)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body += "<tr><td>" + elemant.Id.ToString() + "</td><td>" + elemant.employee_id.ToString() + "</td><td>" + elemant.notes +
                    "</td><td>" + active.ToString() + "</td><td>" + elemant.notes + "</td><td>" + elemant.cost + "</td><td>" + elemant.date.ToString() + "</td></tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void VarriableExpendsRepors()
        {
            IList<variableExpendsTable> varriableExpends = DataLayer.GetAllVariableExpends();
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח הוצאות משתנות</title>" + "</head><body><h1>תוצאות דוח הוצאות משתנות</h1>" +
                          "<table>" +
                          "<thead><tr><th>מזהה</th><th>מזהה עובד</th><th>הערות</th><th>מצב פעילות</th><th>שם ההוצאה</th><th>עלות ההוצאה</th><th>תאריך ההוצאה</th></tr></thead>" +
                          "<tbody>";
            foreach (variableExpendsTable elemant in varriableExpends)
            {
                bool active;
                if (elemant.active == 0)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                body += "<tr><td>" + elemant.Id.ToString() + "</td><td>" + elemant.employee_id.ToString() + "</td><td>" + elemant.notes +
                    "</td><td>" + active.ToString() + "</td><td>" + elemant.notes + "</td><td>" + elemant.cost + "</td><td>" + elemant.date.ToString() + "</td></tr>";
            }
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        public static void Profitability()
        {
            int expends1=0,expends2=0,expends3=0,expends4=0, revenue=0;
            IList<orderDetailsTable> orders = DataLayer.GetAllOrderDetailDL();
            IList<EmployeeTable> employees = DataLayer.GetAllEmployeesDL();
            IList<CurrentExpendsTable> currentExpends = DataLayer.GetAllCurrentExpends();
            IList<variableExpendsTable> variableExpends = DataLayer.GetAllVariableExpends();
            IList<orderFromSupplierDetailTable> ordersFromSupplier = DataLayer.GetAllOrderFromSupplierDetailDL();
            foreach (orderDetailsTable element in orders)
            {
                revenue += Convert.ToInt32((element.cost*element.amount) - element.costPrice - element.discount);
            }
            foreach (EmployeeTable element in employees)
            {
                expends1 += Convert.ToInt32(element.salary);
            }
            foreach (CurrentExpendsTable element in currentExpends)
            {
                expends2 += Convert.ToInt32(element.cost);
            }
            foreach (variableExpendsTable element in variableExpends)
            {
                expends3 += Convert.ToInt32(element.cost);
            }
            foreach (orderFromSupplierDetailTable element in ordersFromSupplier)
            {
                expends4 += Convert.ToInt32(element.amount*element.price);
            }
            int Profitability = revenue - expends1 - expends2 - expends3 - expends4;
            String fileName = Path.GetTempFileName() + ".html";
            string body = "<html><head><style>body { direction:rtl; font-family: Arial, Sans Serif; }" +
                          "table { width: 100%; } " + "thead th { background: gray; }</style>" +
                          "<title>דוח רווחיות</title>" + "</head><body><h1>תוצאות דוח רווחיות</h1>" +
                          "<table>" +
                          "<thead><tr><th>שכר עובדים</th><th>הוצאות שוטפות</th><th>הוצאות משתנות</th><th>הוצאות של הזמנות מספק</th><th>הכנסות</th><th>רווחיות</th></tr></thead>" +
                          "<tbody>";
            body += "<tr><td>" + expends1.ToString() + "</td><td>" + expends2.ToString() + "</td><td>" + expends3.ToString() +
                   "</td><td>" + expends4.ToString() + "</td><td>" + revenue.ToString() + "</td><td>" + Profitability.ToString() + "</td></tr>";
            body += "</tbody></table></body></html>";
            File.WriteAllText(fileName, body);
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        }
    }

