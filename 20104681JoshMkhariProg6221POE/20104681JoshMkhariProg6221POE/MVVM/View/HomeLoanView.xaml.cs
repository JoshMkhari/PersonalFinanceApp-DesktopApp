using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using _20104681JoshMkhariProg6221POE.Logic;
using _20104681JoshMkhariProg6221POE.MVVM.Model;

namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for BudgetPlannerView.xaml
    /// </summary>
    public partial class HomeLoanView : UserControl
    {
        
        double propertyPriceValue, propertDepositValue, numMonthsValue, interestRateValue;

        public HomeLoanView() 
        {
            InitializeComponent();
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                updater.Value = 3;
                currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses();//"Enter VehicleView"
            }
            else
            {
                updater.Value = 1;
            }

        }

        private void PropertyPrice_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            propertyPriceValue = PropertyPrice.Value;
            currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses() + PropertyPrice.Value;
            calculate();
        }


        private void PropertyDeposit_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            propertDepositValue = PropertyDeposit.Value;
            calculate();
        }

        private void NumMonths_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numMonthsValue = NumMonths.Value;
            calculate();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                MonthlyExpenseModel.setCurrentExpenses(MonthlyExpenseModel.getCurrentExpenses() + HomeExpense.Value);
                HomeLoanModel.setMonthlyExpense(HomeExpense.Value);
                BudgetPlannerModel.setCustomExpense(HomeExpense.Value);
                BudgetPlannerModel.setTotalExpenses(HomeExpense.Value);
            }
        }

        private void TPropertyPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TPropertyPrice.Text == "")
            {
                TPropertyPrice.Text = "0";
            }
        }

        private void TPropertyDeposit_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TPropertyDeposit.Text == "")
            {
                TPropertyDeposit.Text = "0";
            }
        }

        private void TNumberMonths_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TNumberMonths.Text == "")
            {
                TNumberMonths.Text = "0";
            }
        }

        private void TInterestRate_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TInterestRate.Text == "")
            {
                TInterestRate.Text = "0";
            }
        }

        private void TPropertyPrice_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TPropertyPrice.Text))//will return false if not character
            {
                PropertyPrice.Value = 0;
                TPropertyPrice.Text = "0";
                e.Handled = true;
            }
        }

        private void TPropertyDeposit_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TPropertyDeposit.Text))//will return false if not character
            {
                PropertyDeposit.Value = 0;
                TPropertyDeposit.Text = "0";
                e.Handled = true;
            }
        }

        private void TNumberMonths_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TNumberMonths.Text))//will return false if not character
            {
                NumMonths.Value = 240;
                TNumberMonths.Text = "0";
                e.Handled = true;
            }
        }

        private void TInterestRate_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TInterestRate.Text))//will return false if not character
            {
                InterestRate.Value = 1;
                TInterestRate.Text = "0";
                e.Handled = true;
            }
        }

        private void InterestRate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            interestRateValue = InterestRate.Value;
            calculate();
        }

        private void calculate()
        {

            if (propertyPriceValue > 0)
            {
                populateHomeLoan();
                MainClass.HomeLoan(MonthlyExpenseModel.getMonthly(), MonthlyExpenseModel.getTax(), MonthlyExpenseModel.getUserExpenseArray());
                HomeExpense.Value = Convert.ToDouble(MainClass.HomeLoanExpense);
                if(BudgetPlannerModel.getBudgetPlanner())
                {
                    currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses() + Convert.ToDouble(MainClass.HomeLoanExpense);
                }
                else
                    currentTotal.Value = Convert.ToDouble(MainClass.HomeLoanExpense);
            }
        }

        void populateHomeLoan()
        {
            MainClass.propertyValuesArray[0] = Convert.ToDecimal(propertyPriceValue);
            MainClass.propertyValuesArray[1] = Convert.ToDecimal(propertDepositValue);
            MainClass.propertyValuesArray[2] = Convert.ToDecimal(interestRateValue);
            MainClass.propertyValuesArray[3] = Convert.ToDecimal(numMonthsValue);
        }


    }

}
