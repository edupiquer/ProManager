using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.Core.Models
{
    public class Staff : Person
    {
        public Team Team { get; set; }
        public Contract Contract { get; set; }
    }
}
