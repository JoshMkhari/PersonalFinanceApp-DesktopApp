using _20104681JoshMkhariProg6221POE.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.MVVM.ViewModel
{
    public class EnterVehicleViewModel:BaseViewModel
    {
            public ICommand UpdateViewCommand { get; set; }
            public EnterVehicleViewModel()
            {

                UpdateViewCommand = new UpdateViewCommand(this);
            }

    }
}
