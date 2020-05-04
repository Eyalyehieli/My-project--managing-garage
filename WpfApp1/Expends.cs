using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Expends
    {
        public static void AddVariableExpend(EmployeeTable selectedEmployee, string notes, string name, int cost,
            DateTime date)
        {
            DataLayer.AddVariableExpend(selectedEmployee,notes,name,cost,date);
        }

        public static void AddCurrentExpend(EmployeeTable selectedEmployee, string notes, string name, int cost,
            DateTime date)
        {
            DataLayer.AddCurrentExpend(selectedEmployee,notes,name,cost,date);
        }

        public static void UpdateVariableExpend(variableExpendsTable selectedVariablrExp, EmployeeTable selectedEmployee,
            string notes, string name, int cost,
            DateTime date, int active)
        {
            DataLayer.UpdateVariableExpend(selectedVariablrExp,selectedEmployee,notes,name,cost,date,active);
        }

        public static void UpdateCurrentExpend(CurrentExpendsTable selectedCurrentExp, EmployeeTable selectedEmployee,
            string notes, string name, int cost,
            DateTime date, int active)
        {
            DataLayer.UpdateCurrentExpend(selectedCurrentExp,selectedEmployee,notes,name,cost,date,active);
        }

        public static IList<variableExpendsTable> GetAllVariableExp()
        {
            return DataLayer.GetAllVariableExpends();
        }

        public static IList<CurrentExpendsTable> GetAllCurentExp()
        {
            return DataLayer.GetAllCurrentExpends();
        }
    }
}
