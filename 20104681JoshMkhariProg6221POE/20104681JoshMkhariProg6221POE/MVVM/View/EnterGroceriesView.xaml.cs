using _20104681JoshMkhariProg6221POE.MVVM.Model;
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

namespace _20104681JoshMkhariProg6221POE.MVVM.View
{
    /// <summary>
    /// Interaction logic for EnterGroceriesView.xaml
    /// </summary>
    public partial class EnterGroceriesView : UserControl
    {
        public EnterGroceriesView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MonthlyExpenseModel.getCurrentExpenses();
        }
    }
}
