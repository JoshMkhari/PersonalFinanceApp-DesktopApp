using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20104681JoshMkhariProg6221POE.MVVM.Model
{
    class SavingsModel
    {
        static double savingMonthly = 0;

        public static void setMonthlyExpense(double expense)
        {
            savingMonthly = expense;
        }

        public static double getMonthlyExpense()
        {
            return savingMonthly;
        }
    }
}
