using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProManager.Core.Models
{
    public class Person : DomainObject
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [NotMapped]
        public TimeSpan Age { get => (DateTime.Now - DateOfBirth); }
    }
}
