using ProManager.Core.Models;
using ProManager.Core.Services;
using ProManager.EntityFramework;
using ProManager.EntityFramework.Service;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<Person> userService = new GenericDataService<Person>(new ProManagerDbContextFactory());
            Console.WriteLine(userService.Get(1).Result);
        }
    }
}
