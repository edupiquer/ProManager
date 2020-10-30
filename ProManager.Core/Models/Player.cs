using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.Core.Models
{
    public enum Position
    {
        Goalkeeper,
        Defender,
        MidFielder,
        Forward
    }

    public enum PlayerDuty
    {
        CentreBack,
        Sweeper,
        FullBack,
        WingBack,
        CentreMidfield,
        DefensiveMidfield,
        AttackingMidfield,
        WideMidfield,
        CentreForward,
        SecondStriker,
        Winger
    }

    public class Player
    {
        public Guid Id { get; set; }
        public Person Person { get; set; }
        public Team Team { get; set; }
        public Contract Contract { get; set; }
        public Position Position { get; set; }
        public PlayerDuty Duty { get; set; }
    }
}
