using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProManager.Core.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(length: 100)]
        public string Name { get; set; }
        [MaxLength(length: 100)]
        public string LastName { get; set; }
        [MaxLength(length: 100)]
        public string SecondLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
