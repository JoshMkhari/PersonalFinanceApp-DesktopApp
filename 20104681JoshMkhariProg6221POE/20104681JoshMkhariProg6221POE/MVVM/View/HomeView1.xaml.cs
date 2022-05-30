using _20104681JoshMkhariProg6221POE.MVVM.Model;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;
using System.Windows.Controls;

namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView1.xaml
    /// </summary>
    public partial class HomeView1 : UserControl
    {
        public HomeView1()
        {
            InitializeComponent();
            this.DataContext = new HomeView1Model();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
        }


        private void Rent_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
            MainViewModel.setCheckRadioButton("Calc");
        }

        private void HomeLoan_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
            MainViewModel.setCheckRadioButton("Calc");
        }

        private void Vehicle_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
            MainViewModel.setCheckRadioButton("Calc");
        }

        private void Savings_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
            MainViewModel.setCheckRadioButton("Calc");
        }

        private void BudgetPlanner_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainViewModel.setCheckRadioButton("Budget");
        }
    }
}
