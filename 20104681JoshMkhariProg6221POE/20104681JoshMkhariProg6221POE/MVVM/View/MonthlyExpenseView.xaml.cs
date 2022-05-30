using _20104681JoshMkhariProg6221POE.Logic;
using _20104681JoshMkhariProg6221POE.MVVM.Model;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for MonthlyExpenseView.xaml
    /// </summary>
    public partial class MonthlyExpenseView : UserControl
    {
        double taxToPay, monthlyIncome;
        double[] expenses = new double[5];

        public MonthlyExpenseView()
        {
            InitializeComponent();
            this.DataContext = new MonthlyExpenseViewModel();
            if (BudgetPlannerModel.getBudgetPlanner())
                if (BudgetPlannerModel.getChosen()==1)
                {
                    updater.Value = 2;
                }
                else
                {
                    updater.Value = 6;
                }
                    
            else
                updater.Value = 1;
        }

        private void Tax_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(Tax.Value.ToString() == null)
            {
                taxToPay = 0;
            }
            else
            taxToPay = Tax.Value;
        }

        private void GrossMonthlyIncome_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (GrossMonthlyIncome.Value.ToString() == null)
            {
                monthlyIncome = 0;
            }
            else
                monthlyIncome = GrossMonthlyIncome.Value;
        }

        private void Groceries_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Groceries.Value.ToString() == null)
            {
                expenses[0] = 0;
            }
            else
                expenses[0] = Groceries.Value;
        }

        private void WaterL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (WaterL.Value.ToString() == null)
            {
                expenses[1] = 0;
            }
            else
                expenses[1] = WaterL.Value;
        }

        private void Travel_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Travel.Value.ToString() == null)
            {
                expenses[2] = 0;
            }
            else
                expenses[2] = Travel.Value;
        }

        private void Cell_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Cell.Value.ToString() == null)
            {
                expenses[3] = 0;
            }
            else
                expenses[3] = Cell.Value;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if(GrossMonthlyIncome.Value == 0)
            {
                updater.Value = 1;
            }
            populate();
            MonthlyExpenseModel.setUserIncome(monthlyIncome);
        }

        private void Other_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Other.Value.ToString() == null)
            {
                expenses[4] = 0;
            }
            else
                expenses[4] = Other.Value;

        }

        private void TGrossMonthlyIncome_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TGrossMonthlyIncome.Text == "")
            {
                TGrossMonthlyIncome.Text = "0";
            }
        }

        private void TTax_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TTax.Text == "")
            {
                TTax.Text = "0";
            }
        }

        private void TGroceries_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TGroceries.Text == "")
            {
                TGroceries.Text = "0";
            }
        }

        private void TWaterL_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TWaterL.Text == "")
            {
                TWaterL.Text = "0";
            }
        }

        private void TTravel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TTravel.Text == "")
            {
                TTravel.Text = "0";
            }
        }

        private void TOther_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TOther.Text == "")
            {
                TOther.Text = "0";
            }
        }

        private void TCell_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TCell.Text == "")
            {
                TCell.Text = "0";
            }
        }

        private void TGrossMonthlyIncome_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TGrossMonthlyIncome.Text))//will return false if not character
            {
                GrossMonthlyIncome.Value = 0;
                TGrossMonthlyIncome.Text = "0";
                e.Handled = true;
            }
        }

        private void TGroceries_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TGroceries.Text))//will return false if not character
            {
                Groceries.Value = 0;
                TGroceries.Text = "0";
                e.Handled = true;
            }
        }

        private void TWaterL_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TWaterL.Text))//will return false if not character
            {
                WaterL.Value = 0;
                TWaterL.Text = "0";
                e.Handled = true;
            }
        }

        private void TTravel_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TTravel.Text))//will return false if not character
            {
                Travel.Value = 0;
                TTravel.Text = "0";
                e.Handled = true;
            }
        }

        private void TCell_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TCell.Text))//will return false if not character
            {
                Cell.Value = 0;
                TCell.Text = "0";
                e.Handled = true;
            }
        }

        private void TOther_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TOther.Text))//will return false if not character
            {
                Other.Value = 0;
                TOther.Text = "0";
                e.Handled = true;
            }
        }

        void populate()
        {
            double currentExpenses = 0;
            if (monthlyIncome != 0)
            {
                MonthlyExpenseModel.setUserExpenseArray(expenses);
                MonthlyExpenseModel.setBasics(monthlyIncome, taxToPay);
            }

            for (int x = 0; x < 5; x++)//Runs through the array and retrieves an expense and incrememnts the total expense value variable by the retrieved expense.
            {
                currentExpenses += expenses[x];//Increment the total expense value variable by the current index within the expense array.
            }
            currentExpenses += taxToPay;
            MonthlyExpenseModel.setCurrentExpenses(currentExpenses);
            BudgetPlannerModel.setTotalExpenses(currentExpenses);
        }


    }
}
