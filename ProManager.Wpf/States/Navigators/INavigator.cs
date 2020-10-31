using ProManager.Wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProManager.Wpf.States.Navigators
{
    public enum ViewType
    {
        Home,
        Teams,
        Players,
        Coaches
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
