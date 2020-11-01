using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.Wpf.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public FakePersonViewModel FakePersonViewModel { get; set; }

        public HomeViewModel(FakePersonViewModel fakePersonViewModel)
        {
            FakePersonViewModel = fakePersonViewModel;
        }
    }
}
