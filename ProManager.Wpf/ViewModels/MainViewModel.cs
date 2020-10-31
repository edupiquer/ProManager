using ProManager.Wpf.States.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.Wpf.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
