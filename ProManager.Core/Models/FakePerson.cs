using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProManager.Core.Models
{
    [NotMapped]
    public class FakePerson
    {
        public string first { get; set; }
        public string last { get; set; }
        public DateTime date { get; set; }
        public int age { get; set; }
    }
}
