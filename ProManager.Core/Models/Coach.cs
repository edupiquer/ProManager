using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.Core.Models
{
    public enum CoachType
    {
        General,
        Goalkeeper,
        Athletism,
        Mental,
        Nutritionist
    }
    public class Coach : DomainObject
    {
        public Person Person { get; set; }
        public Team Team { get; set; }
        public Contract Contract { get; set; }
        public CoachType Type { get; set; }
    }
}
