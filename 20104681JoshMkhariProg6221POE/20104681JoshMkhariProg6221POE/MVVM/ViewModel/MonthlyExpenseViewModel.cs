using _20104681JoshMkhariProg6221POE.Commands;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.MVVM.ViewModel
{
    public class MonthlyExpenseViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        public MonthlyExpenseViewModel()
        {

            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
