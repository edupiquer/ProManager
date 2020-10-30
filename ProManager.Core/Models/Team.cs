using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProManager.Core.Models
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(length:100)]
        public string Name { get; set; }
        public List<Coach> Coaches { get; set; }
        public List<Player> Players { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
