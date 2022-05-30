using _20104681JoshMkhariProg6221POE.Commands;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace _20104681JoshMkhariProg6221POE.MVVM.ViewModel
{
    public class HomeLoanViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        public HomeLoanViewModel()
        {

            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
