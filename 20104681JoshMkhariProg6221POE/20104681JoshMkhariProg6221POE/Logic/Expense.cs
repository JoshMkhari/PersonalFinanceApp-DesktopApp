using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20104681JoshMkhariProg6221POE.Logic
{
    abstract class Expense//Used to derive HomeLoan and Rent class
    {
        //properties
        public decimal GrossMonthlyIncomeValue { get; set; }//Stores the users Gross Monthly Income.
        public decimal MonthlyTaxValue { get; set; }//Stores the users Monthly Tax.
        public decimal AvailBalValue { get; set; }//Stores the available monthly money after all deductions.
        public decimal TotalExpensesValue { get; set; }//Stores the sum of expenses of the user.
        public String ClassUniqueExpense { get; set; }// stores an expense of type string
        public decimal MonthlyExpense { get; set; }// stores the class specific monthly expense

        //private declerations
        private List<decimal> userExpensesList = new List<decimal>();//Used to store the users expenses.

        //sets
        public void SetUserExpensesList(decimal[] expensesArray)//Used to set the array of Expenses from the Main Class.
        {

            this.userExpensesList.AddRange(expensesArray);
        }

        //gets
        public List<decimal> GetUserExpensesList()//Used to retrieve the stored expenses array.
        {
            return this.userExpensesList;
        }
        //abstract methods
        public abstract void CalculateExpenses();//Used to calculate expenses in each of the derived classes.
    }
}
