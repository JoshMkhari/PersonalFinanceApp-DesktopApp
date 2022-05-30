using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _20104681JoshMkhariProg6221POE.Logic
{
    class Vehicle : Expense
    {
        decimal currentTotalExpenses = 0;//stores total expenses

        public override void CalculateExpenses()//Used to calculate the total expenses and calculate the available balance.
        {

            List<decimal> expensesList = new List<decimal>();// retrieves the users expenses array
            expensesList.AddRange(this.GetUserExpensesList());

            double loanAmountValue = Decimal.ToDouble(expensesList[0] - expensesList[1]); //Purchase Price - Total Deposit
            double B = Decimal.ToDouble(expensesList[2] / 100) / 12;
            double C = 1 - Math.Pow(1 + B, -60);
            this.MonthlyExpense = Convert.ToDecimal(loanAmountValue * (B / C));// Calculates how much is to be paide monthly without insurance
            this.TotalExpensesValue = Math.Round(this.MonthlyExpense + expensesList[3], 2); //Calculates how much is to be paid monthly with insurance Rounded to 2 decimal places
        }

        public void SetCurrentTotalExpenses(double total)//Used to set the array of Expenses from the Main Class.
        {

            this.currentTotalExpenses = Convert.ToDecimal(total) + this.TotalExpensesValue;
        }

        //gets
        public decimal GetCurrentTotalExpenses()//Used to retrieve the stored expenses array.
        {
            return this.currentTotalExpenses;
        }

        public static void Exceeded(string message)//delegate call
        {
            MessageBox.Show(message,"Warning Vehicle Exceeded", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
