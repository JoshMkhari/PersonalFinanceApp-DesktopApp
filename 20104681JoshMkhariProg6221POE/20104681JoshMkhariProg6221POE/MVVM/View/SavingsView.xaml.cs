using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _20104681JoshMkhariProg6221POE.Logic;
using _20104681JoshMkhariProg6221POE.MVVM.Model;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;
namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for SavingsView.xaml
    /// </summary>
    public partial class SavingsView : UserControl
    {
        decimal[] savingsValues = new decimal[5];
        Boolean changed = false;
        //goal,years,initialDeposit,interestrate
        public SavingsView()
        {
            InitializeComponent();
            this.DataContext = new SavingsViewModel();
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses();
                updater.Value = 5;//"Final Expenses"
            }
            else
            {
                BudgetPlannerModel.resetPlanner();
                currentTotal.Value = 0;
                updater.Value = 1;
            }



        }
        private void Balance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            savingsValues[2] = Convert.ToDecimal(Balance.Value);
            Calculate();
        }
        private void InterestRate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            savingsValues[3] = Convert.ToDecimal(InterestRate.Value);
            Calculate();
        }
        private void Years_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            savingsValues[1] = Convert.ToDecimal(Years.Value);
            Calculate();
        }
        private void Goal_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            savingsValues[0] = Convert.ToDecimal(Goal.Value);
            changed = true;
            Calculate();
        }

        public void Calculate()
        {
            if (changed)
            {
                MainClass.SavingsCall(savingsValues);
                SavingsAmount.Value = Convert.ToDouble(MainClass.monthlySavings);
                if (BudgetPlannerModel.getBudgetPlanner())
                {
                    currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses() + Convert.ToDouble(MainClass.monthlySavings);
                }
                else
                    currentTotal.Value = Convert.ToDouble(MainClass.monthlySavings);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                MonthlyExpenseModel.setCurrentExpenses(currentTotal.Value);
                SavingsModel.setMonthlyExpense(SavingsAmount.Value);
                BudgetPlannerModel.setTotalExpenses(SavingsAmount.Value);
            }
        }

        private void TGoal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TGoal.Text == "")
            {
                TGoal.Text = "0";
            }
        }

        private void TSavingName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TSavingName.Text == "")
            {
                TSavingName.Text = "Unidentified Savings";
            }
        }

        private void TBalance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBalance.Text == "")
            {
                TBalance.Text = "0";
            }
        }

        private void TInterest_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TInterest.Text == "")
            {
                TInterest.Text = "1";
            }
        }

        private void TYears_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TYears.Text == "")
            {
                TYears.Text = "1";
            }
        }

        private void TGoal_KeyDown(object sender, KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TGoal.Text))//will return false if not character
            {
                Goal.Value = 0;
                TGoal.Text = "0";
                e.Handled = true;
            }
        }

        private void TBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TBalance.Text))//will return false if not character
            {
                Balance.Value = 0;
                TBalance.Text = "0";
                e.Handled = true;
            }
        }

        private void TInterest_KeyDown(object sender, KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TInterest.Text))//will return false if not character
            {
                InterestRate.Value = 1;
                TInterest.Text = "0";
                e.Handled = true;
            }
        }

        private void TYears_KeyDown(object sender, KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TYears.Text))//will return false if not character
            {
                Years.Value = 0;
                TYears.Text = "0";
                e.Handled = true;
            }
        }
    }
}
