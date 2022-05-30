using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20104681JoshMkhariProg6221POE.MVVM.Model
{
    class RentModel
    {
        static decimal rentValue = 0;

        public static void setRent(double rent)
        {
            rentValue = Convert.ToDecimal(rent);
        }

        public static decimal getRent()
        {
            return rentValue;
        }
    }
}
