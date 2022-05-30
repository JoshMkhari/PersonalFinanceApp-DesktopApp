using _20104681JoshMkhariProg6221POE.Logic;
using _20104681JoshMkhariProg6221POE.MVVM.Model;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for RentView.xaml
    /// </summary>
    public partial class RentView : UserControl
    {
        double userRent;
        public RentView()
        {
            InitializeComponent();
            this.DataContext = new RentViewModel();
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses();
                updater.Value = 3;//"Enter VehicleView"
            }
            else
            {
                updater.Value = 1;
            }
        }

        private void Rent_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            userRent = Rent.Value;

                MainClass.setRent(userRent);
                RentExpense.Value = userRent;
                if (BudgetPlannerModel.getBudgetPlanner())
                {
                    currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses() + userRent;
                }
                else
                    currentTotal.Value = userRent;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                RentModel.setRent(userRent);
                BudgetPlannerModel.setCustomExpense(userRent);
                MonthlyExpenseModel.setCurrentExpenses(MonthlyExpenseModel.getCurrentExpenses() + userRent);
                BudgetPlannerModel.setTotalExpenses(userRent);
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            RentExpense.Value = 0;
        }

        private void TRent_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TRent.Text == "")
            {
                TRent.Text = "0";
            }
        }

        private void TRent_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TRent.Text))//will return false if not character
            {
                Rent.Value = 0;
                TRent.Text = "0";
                e.Handled = true;
            }
        }
    }
}
