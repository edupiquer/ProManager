using ProManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.Core.Services
{
    public interface IFakePersonService
    {
        Task<FakePerson> GetFakePerson();
    }
}
