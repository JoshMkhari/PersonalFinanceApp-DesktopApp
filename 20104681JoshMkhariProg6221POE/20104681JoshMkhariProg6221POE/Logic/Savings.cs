using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20104681JoshMkhariProg6221POE.Logic
{
    class Savings : Expense
    {
        private List<decimal> savingsValueList = new List<decimal>();
        public override void CalculateExpenses()//Used to calculate the total expenses and calculate the available balance.
        {
            //goal,years,initialDeposit,interestrate
            this.savingsValueList.AddRange(this.GetUserExpensesList()); //Populate savings list

            double goal = Decimal.ToDouble(this.savingsValueList[0]);// populate goal
            double initial = Decimal.ToDouble(this.savingsValueList[2]);//populate initial starting amount
            double interrestRate = 1 + Decimal.ToDouble(this.savingsValueList[3] / 100 / 12);//set interest rate 
            double years = Decimal.ToDouble(this.savingsValueList[1]) * 12;//set years
            double interestRatePow = Math.Pow(interrestRate, years);//set interest rate to the power of years
            double variableA = (interrestRate - 1) * (goal - initial * (interestRatePow)); // Line A (Explained in Word Doc)
            double variableB = interestRatePow - 1;//Line B (Explained in word Doc)
            this.MonthlyExpense = Convert.ToDecimal(variableA / variableB);// Final answer
        }

    }
}
