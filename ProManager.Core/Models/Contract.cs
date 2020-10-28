using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.Core.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public Team Team { get; set; }
        public int Duration { get; set; }
        public int Value { get; set; }
    }
}
