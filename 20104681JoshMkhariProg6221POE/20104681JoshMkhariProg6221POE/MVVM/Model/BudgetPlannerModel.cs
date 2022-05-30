using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20104681JoshMkhariProg6221POE.MVVM.Model
{
    class BudgetPlannerModel
    {
        static Boolean budgetPlanner,complete;
        static int chosen;
        static decimal customHomeExpense;
        static double TotalExpenses = 0;
        public static void setCustomExpense(double expense)
        {
            customHomeExpense = Convert.ToDecimal(expense);
        }

        public static void setTotalExpenses(double expense)
        {
            TotalExpenses += (expense);
        }
        public static double getTotalExpenses()
        {
            return TotalExpenses;
        }
        public static decimal getCustomExpense()
        {
            return customHomeExpense;
        }
        public static void resetPlanner()
        {
            budgetPlanner = false;
            complete = false;
            chosen =0;
            MonthlyExpenseModel.setCurrentExpenses(0);
            HomeLoanModel.setMonthlyExpense(0);

        }
        public static void setBudgetPlanner(Boolean set)
        {
            budgetPlanner = set;
        }

        public static Boolean getBudgetPlanner()
        {
            return budgetPlanner;
        }

        public static void setComplete(Boolean set)
        {
            complete = set;
        }

        public static Boolean getComplete()
        {
            return complete;
        }

        public static void setChosen(int set)
        {
            chosen = set;
        }

        public static int getChosen()
        {
            return chosen;
        }
    }
}
