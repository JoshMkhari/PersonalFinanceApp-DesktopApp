using _20104681JoshMkhariProg6221POE.Commands;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.MVVM.ViewModel
{
    public class RentViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        public RentViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
