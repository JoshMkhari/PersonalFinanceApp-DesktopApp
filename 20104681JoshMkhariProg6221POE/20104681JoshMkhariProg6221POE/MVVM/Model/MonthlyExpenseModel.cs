using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20104681JoshMkhariProg6221POE.MVVM.Model
{
    class MonthlyExpenseModel
    {
        static decimal[] userExpenseArray = new decimal[5];
        static decimal monthlyIncome, tax;
        static double currentExpenses=0;
        static double userIncome = 0;
        public static void setUserExpenseArray(double[] expenses)
        {
            userExpenseArray[0] = Convert.ToDecimal(expenses[0]);
            userExpenseArray[1] = Convert.ToDecimal(expenses[1]);
            userExpenseArray[2] = Convert.ToDecimal(expenses[2]);
            userExpenseArray[3] = Convert.ToDecimal(expenses[3]);
            userExpenseArray[4] = Convert.ToDecimal(expenses[4]);
        }

        public static decimal[] getUserExpenseArray()
        {
            return userExpenseArray;
        }

        public static double getCurrentExpenses()
        {
            return currentExpenses;
        }

        public static void setCurrentExpenses(double set)
        {
            
            currentExpenses = set;
        }

        public static void setBasics(double monthly,double estTax)
        {
            monthlyIncome = Convert.ToDecimal(monthly);
            tax = Convert.ToDecimal(estTax);
        }

        public static double getMonthlyIncome()
        {
            return userIncome;
        }

        public static void setUserIncome(double income)
        {
            userIncome = income;
        }
        public static decimal getMonthly()
        {
            return monthlyIncome;
        }

        public static decimal getTax()
        {
            return tax;
        }

    }
}
