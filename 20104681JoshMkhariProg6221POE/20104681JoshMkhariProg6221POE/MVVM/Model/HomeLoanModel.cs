using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20104681JoshMkhariProg6221POE.Logic;

namespace _20104681JoshMkhariProg6221POE.MVVM.Model
{
    class HomeLoanModel 
    {
        static double homeLoanMonthlyExpense = 0;

        public static void setMonthlyExpense(double expense)
        {
            homeLoanMonthlyExpense = expense;
        }

        public static double getMonthlyExpense()
        {
            return homeLoanMonthlyExpense;
        }

    }
}
