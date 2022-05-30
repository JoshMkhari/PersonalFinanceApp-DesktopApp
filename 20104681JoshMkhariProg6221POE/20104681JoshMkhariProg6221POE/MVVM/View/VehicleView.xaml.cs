using _20104681JoshMkhariProg6221POE.Logic;
using _20104681JoshMkhariProg6221POE.MVVM.Model;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for VehicleView.xaml
    /// </summary>
    public partial class VehicleView : UserControl
    {
        decimal[] vehicleExpenses = new decimal[5];
        Boolean changed = false;
        public VehicleView()
        {
            InitializeComponent();
            this.DataContext = new VehicleViewModel();
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses();
                updater.Value = 4;//"ChooseSavings or not"
            }
            else
            {
                updater.Value = 1;
            }
        }

        private void PurchasePrice_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vehicleExpenses[0] = Convert.ToDecimal(PurchasePrice.Value);
            changed = true;
            Calculate();
        }

        private void DownPayment_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vehicleExpenses[1] = Convert.ToDecimal(DownPayment.Value);
            Calculate();
        }

        private void InterestRate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vehicleExpenses[2] = Convert.ToDecimal(InterestRate.Value);
            Calculate();
        }

        private void Insurance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vehicleExpenses[3] = Convert.ToDecimal(Insurance.Value);
            Calculate();
        }

        public void Calculate()
        {
            if (changed)
            {
                MainClass.Vehicles(vehicleExpenses);
                VehicleExpense.Value = Convert.ToDouble(MainClass.VehicleExpense);
                if (BudgetPlannerModel.getBudgetPlanner())
                {
                    currentTotal.Value = MonthlyExpenseModel.getCurrentExpenses() + Convert.ToDouble(MainClass.VehicleExpense);
                }
                else
                    currentTotal.Value = Convert.ToDouble(MainClass.VehicleExpense);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                MonthlyExpenseModel.setCurrentExpenses(currentTotal.Value);
                VehicleModel.setMonthlyExpense(VehicleExpense.Value);
                BudgetPlannerModel.setTotalExpenses(VehicleExpense.Value);
                MainClass.checkDel(MonthlyExpenseModel.getCurrentExpenses(),MonthlyExpenseModel.getMonthlyIncome());
            }
        }

        private void TPurchasePrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TPurchasePrice.Text == "")
            {
                TPurchasePrice.Text = "0";
            }
        }

        private void TDownPayment_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TDownPayment.Text == "")
            {
                TDownPayment.Text = "0";
            }
        }

        private void TInsurance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TInsurance.Text == "")
            {
                TInsurance.Text = "1";
            }
        }

        private void TInterestRate_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TInterestRate.Text == "")
            {
                TInterestRate.Text = "0";
            }
        }

        private void TVehicleName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TVehicleName.Text == "")
            {
                TVehicleName.Text = "Unidentified Vehicle";
            }
        }

        private void TPurchasePrice_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TPurchasePrice.Text))//will return false if not character
            {
                PurchasePrice.Value = 0;
                TPurchasePrice.Text = "0";
                e.Handled = true;
            }
        }

        private void TDownPayment_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TDownPayment.Text))//will return false if not character
            {
                DownPayment.Value = 0;
                TDownPayment.Text = "0";
                e.Handled = true;
            }
        }

        private void TInsurance_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!MainClass.DecimalCheck(TInsurance.Text))//will return false if not character
            {
                Insurance.Value = 0;
                TInsurance.Text = "0";
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
    }
}
