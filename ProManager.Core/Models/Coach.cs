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
    public class Coach : Staff
    {
        public CoachType Type { get; set; }
    }
}
