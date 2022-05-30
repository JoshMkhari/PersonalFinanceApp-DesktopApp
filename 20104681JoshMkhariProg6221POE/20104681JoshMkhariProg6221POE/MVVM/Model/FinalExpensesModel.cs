using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20104681JoshMkhariProg6221POE.MVVM.Model
{
    public class FinalExpensesModel
    {
        public static String userExpensesList = "";

        public static void setUserExpensesList(String data)
        {
            userExpensesList = data;
        }

        public static string getUserExpenseList()
        {
            return userExpensesList;
        }
    }
}
