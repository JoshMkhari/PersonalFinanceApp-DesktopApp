using _20104681JoshMkhariProg6221POE.Commands;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.MVVM.ViewModel
{
    public class BudgetPlannerViewModel : BaseViewModel//budget planner page controller
    {
        public ICommand UpdateViewCommand { get; set; }
        public BudgetPlannerViewModel()
        {

            UpdateViewCommand = new UpdateViewCommand(this);
        }

    }
}
