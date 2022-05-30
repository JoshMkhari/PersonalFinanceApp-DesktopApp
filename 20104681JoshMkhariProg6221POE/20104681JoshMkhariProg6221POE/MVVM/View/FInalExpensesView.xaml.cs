using _20104681JoshMkhariProg6221POE.Logic;
using _20104681JoshMkhariProg6221POE.MVVM.Model;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;
using System;
using System.Windows.Controls;

namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for FInalExpensesView.xaml
    /// </summary>
    public partial class FInalExpensesView : UserControl
    {
        public FInalExpensesView()
        {
            InitializeComponent();
            String output;
            this.DataContext = new FinalExpensesViewModel();
            availableBalance.Value = MonthlyExpenseModel.getMonthlyIncome() - MonthlyExpenseModel.getCurrentExpenses();
            MonthlyRepayment.Value = MonthlyExpenseModel.getCurrentExpenses();
            if(VehicleModel.getMonthlyExpense()!=0)
            {
                if (SavingsModel.getMonthlyExpense() != 0)
                {
                    output = MainClass.DisplayExpenses(true, true);
                }
                else
                    output = MainClass.DisplayExpenses(true,false);
            }
            else
            {
                if(SavingsModel.getMonthlyExpense()!=0)
                {
                    output = MainClass.DisplayExpenses(false,true);
                }
                else
                    output = MainClass.DisplayExpenses(false, false);
            }
            output = output + "\n" + "Total Monthly Expenses: \t\t  R" + Math.Round(BudgetPlannerModel.getTotalExpenses(),2);
            output = output + "\n" + "Available Money After all Expenses: \t  R" + Math.Round(MonthlyExpenseModel.getMonthlyIncome() - BudgetPlannerModel.getTotalExpenses(), 2);
            output = output + "\n" + "-----------------------------------------------------------";
            Expenses.Text = output;
            TAvailableBalance.Text = "" + Math.Round(MonthlyExpenseModel.getMonthlyIncome() - BudgetPlannerModel.getTotalExpenses(), 2);
        }
    }
}
