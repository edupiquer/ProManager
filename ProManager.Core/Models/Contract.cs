using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProManager.Core.Models
{
    public class Contract : DomainObject
    {
        public Person Person { get; set; }
        public Team Team { get; set; }
        public int Duration { get; set; }
        public int Value { get; set; }
    }
}
