using _20104681JoshMkhariProg6221POE.MVVM.Model;
using _20104681JoshMkhariProg6221POE.MVVM.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            var viewModel = (MainViewModel)DataContext;
            if (viewModel.UpdateViewCommand.CanExecute("Home"))
            { viewModel.UpdateViewCommand.Execute("Home"); } 
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
            Console.WriteLine("we triggered");
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            BudgetPlannerModel.resetPlanner();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
