using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20104681JoshMkhariProg6221POE.Logic
{
    class Rent : Expense//Inherits from Expense class
    {

        public override void CalculateExpenses()//Used to calculate the total expenses and calculate the available balance.
        {
            List<decimal> expensesList = new List<decimal>();// retrieves the users expenses array.
            expensesList.AddRange(this.GetUserExpensesList());
            this.TotalExpensesValue = 0;//Initializing the total expense variable.
            for (int x = 0; x < 5; x++)//Runs through the array and retrieves an expense and incrememnts the total expense value variable by the retrieved expense.
            {
                this.TotalExpensesValue += expensesList[x];//Increment the total expense value variable by the current index within the expense array.
            }
            this.TotalExpensesValue = this.TotalExpensesValue + this.MonthlyTaxValue + this.MonthlyExpense;//Incrementing total expense with the monthly tax and rental amounts.
            this.AvailBalValue = this.GrossMonthlyIncomeValue - this.TotalExpensesValue;//Sets the available balance by subtracting all the expenses from the gross monthly income.


        }

    }
}
