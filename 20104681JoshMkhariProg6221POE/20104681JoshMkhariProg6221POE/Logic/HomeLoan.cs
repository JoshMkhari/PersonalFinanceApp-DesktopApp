using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using _20104681JoshMkhariProg6221POE.MVVM.Model;
using _20104681JoshMkhariProg6221POE.MVVM.View;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;

namespace _20104681JoshMkhariProg6221POE.Logic
{
    class HomeLoan : Expense//Inherits from Expense class
    {
        //properties
        private List<decimal> homeLoanValuesList = new List<decimal>();
        public override void CalculateExpenses()//Used to calculate the total expenses and calculate the available balance.
        {

            double loanAmountValue = Decimal.ToDouble(this.homeLoanValuesList[0]) - Decimal.ToDouble(this.homeLoanValuesList[1]);
            /*
             *loan amount
             *Determines how much of the loan needs to be repaid by subtracting the deposit from the property value
             */
            //Home loan calculation formula, All values converted to Double as Math Pow function requires doubles
            double variableD = 1 + Decimal.ToDouble((this.homeLoanValuesList[2] / 100) / 12);//1+r (explained in word document see home loan class section)
            double numMonths = Decimal.ToDouble(this.homeLoanValuesList[3]);//Retrieveing the number of months
            double variableB = Math.Pow(variableD, numMonths) - 1;//(1+r)^(n)-1 (explained in word document see home loan class section)
            double variableC = (variableD - 1) * Math.Pow(variableD, numMonths);// (1+r)*(1+r)^(n) (explained in word document see home loan class section)
            double divisionOfVariables = variableB / variableC;// division of b and c (explained in word document)
            this.MonthlyExpense = Convert.ToDecimal(loanAmountValue / divisionOfVariables);//Setting monthly repayment - final division (explained in word document see home loan class section)
           ;
            //

            //           "Groceries cost","Water and lights cost","Travel costs (including petrol)","Your phone bill cost (cell and tell)" ,//5
            //"Other expenses in total"
            if (BudgetPlannerModel.getBudgetPlanner()) //if in budget planner mode
            {
                if (this.MonthlyExpense > (this.GrossMonthlyIncomeValue / 3))//check if the monthly repayments are more than a third of the users gross monthly income.
                {
                    MessageBox.Show("The monthly home loan repayment of R" + Math.Round(this.MonthlyExpense) + " is greater than a third of your gross monthly income. Approval for this loan is unlikely.",
                        "Home Loan Unlikely",MessageBoxButton.OK,MessageBoxImage.Warning);
                }
                List<decimal> expensesList = new List<decimal>();// retrieves the users expenses array.
                expensesList.AddRange(this.GetUserExpensesList());
                this.TotalExpensesValue = 0;//Initializing the total expense variable.
                for (int x = 0; x < 5; x++)//Runs through the array and retrieves an expense and incrememnts the total expense value variable by the retrieved expense.
                {
                    this.TotalExpensesValue += expensesList[x];//Increment the total expense value variable by the current index within the expense array.
                }

                this.TotalExpensesValue = this.TotalExpensesValue + this.MonthlyTaxValue + this.MonthlyExpense;//Incrementing total expense with the monthly tax and calculated monthly home loan repayment.
                this.AvailBalValue = this.GrossMonthlyIncomeValue - this.TotalExpensesValue;//Sets the available balance by subtracting all the expenses from the gross monthly income.
            }

        }

        public void SetLoanExpensesList(decimal[] expensesArray)//Used to set the array of Expenses from the Main Class.
        {

            this.homeLoanValuesList.AddRange(expensesArray);

        }
    }
}
