using System.Windows.Controls;
using System;
using _20104681JoshMkhariProg6221POE.MVVM.Model;

namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for BudgetPlannerView.xaml
    /// </summary>
    public partial class BudgetPlannerView : UserControl
    {
        public BudgetPlannerView()
        {
            InitializeComponent();
        }

        private void Homeloan_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BudgetPlannerModel.setBudgetPlanner(true);
            BudgetPlannerModel.setChosen(1);
        }

        private void Rent_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BudgetPlannerModel.setBudgetPlanner(true);
            BudgetPlannerModel.setChosen(2);
        }
    }
}
