using ProManager.Core.Models;
using ProManager.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.Wpf.ViewModels
{
    public class FakePersonViewModel
    {
        private readonly IFakePersonService _fakePersonService;

        public FakePerson FakePerson { get; set; }

        public FakePersonViewModel(IFakePersonService fakePersonService)
        {
            _fakePersonService = fakePersonService;
        }

        public static FakePersonViewModel LoadFakePersonViewModel(IFakePersonService fakePersonService)
        {
            FakePersonViewModel fakePersonViewModel = new FakePersonViewModel(fakePersonService);
            fakePersonViewModel.LoadFakePerson();
            return fakePersonViewModel;
        }

        private void LoadFakePerson()
        {
            _fakePersonService.GetFakePerson().ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    FakePerson = task.Result;
                }
            });
        }
    }
}
