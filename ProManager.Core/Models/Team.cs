using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProManager.Core.Models
{
    public class Team : DomainObject
    {
        [MaxLength(length:100)]
        public string Name { get; set; }
        public List<Coach> Coaches { get; set; }
        public List<Player> Players { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
