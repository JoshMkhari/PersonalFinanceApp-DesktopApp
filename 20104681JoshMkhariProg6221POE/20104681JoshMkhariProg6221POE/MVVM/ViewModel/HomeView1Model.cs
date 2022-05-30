using _20104681JoshMkhariProg6221POE.Commands;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.MVVM.ViewModel
{
    public class HomeView1Model : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        public HomeView1Model()
        {

            UpdateViewCommand = new UpdateViewCommand(this);
        }


    }
}
