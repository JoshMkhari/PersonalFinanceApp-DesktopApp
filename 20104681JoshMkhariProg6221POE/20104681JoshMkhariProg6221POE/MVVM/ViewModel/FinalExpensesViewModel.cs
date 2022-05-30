using _20104681JoshMkhariProg6221POE.Commands;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.MVVM.ViewModel
{
    public class FinalExpensesViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        public FinalExpensesViewModel()
        {

            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
