using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;
using System;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;
        private static MainViewModel currentView;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
            currentView = viewModel;
        }

        public UpdateViewCommand(HomeView1Model homeView1Model)
        {

            this.viewModel = currentView;
        }

        public UpdateViewCommand(BudgetPlannerViewModel budgetPlannerModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(EnterGroceriesViewModel enterGroceriesViewModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(MonthlyExpenseViewModel monthlyExpenseViewModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(HomeLoanViewModel homeLoanViewModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(EnterVehicleViewModel enterVehicleViewModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(VehicleViewModel vehicleViewModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(EnterSavingsViewModel enterSavingsViewModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(SavingsViewModel savingsViewModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(RentViewModel rentViewModel)
        {
            this.viewModel = currentView;
        }

        public UpdateViewCommand(FinalExpensesViewModel finalExpensesViewModel)
        {
            this.viewModel = currentView;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Home":
                case "1":
                    viewModel.SelectedViewModel = new HomeView1Model();
                    break;
                case "BudgetPlanner":
                    viewModel.SelectedViewModel = new BudgetPlannerViewModel();
                    break;
                case "HomeLoan":
                case "2":
                    viewModel.SelectedViewModel = new HomeLoanViewModel();
                    break;
                case "MonthlyExpenses":
                    viewModel.SelectedViewModel = new MonthlyExpenseViewModel();
                    break;
                case "Rent":
                case "6":
                    viewModel.SelectedViewModel = new RentViewModel();
                    break;
                case "Vehicle":
                    viewModel.SelectedViewModel = new VehicleViewModel();
                    break;
                case "FinalExpenses":
                case "5":
                    viewModel.SelectedViewModel = new FinalExpensesViewModel();
                    break;
                case "Savings":
                    viewModel.SelectedViewModel = new SavingsViewModel();
                    break;
                case "ChooseGroceries":
                    viewModel.SelectedViewModel = new EnterGroceriesViewModel();
                    break;
                case "3":
                    viewModel.SelectedViewModel = new EnterVehicleViewModel();
                    break;
                case "4":
                    viewModel.SelectedViewModel = new EnterSavingsViewModel();
                    break;
                default:
                    viewModel.SelectedViewModel = new HomeView1Model();
                    break;
            }
        }
    }

}
