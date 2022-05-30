using _20104681JoshMkhariProg6221POE.Commands;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.MVVM.ViewModel
{
    public class VehicleViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        public VehicleViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }

    }
}
