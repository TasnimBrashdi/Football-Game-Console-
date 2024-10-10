using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Football_Game_Console_Simulator.Players;

namespace Football_Game_Console_Simulator
{
    public class Players
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Skill { get; set; }

        public Players(string name, string position, int skill)
        {
            Name = name;
            Position = position;
            Skill = skill;
        }
    }

    public class Player
    {
        public List<Players> playerList;

        public Player()
        {
            playerList = new List<Players>
        {
            new Players("P1", "Forward", 0),
            new Players("P2", "Midfielder", 0),
            new Players("P3", "Defender", 0),
            new Players("P4", "Midfielder", 0),
            new Players("P5", "Forward", 0),
            new Players("P6", "Midfielder", 0),
            new Players("P7", "Defender", 0),
            new Players("P8", "Goalkeeper", 0),
            new Players("P9", "Forward", 0),
            new Players("P10", "Forward", 0),
            new Players("P11", "Defender", 0),
            new Players("P12", "Defender", 0), 
            new Players("P13", "Midfielder", 0),
            new Players("P14", "Defender", 0),
            new Players("P15", "Goalkeeper", 0),
            new Players("P16", "Forward", 0),
            new Players("P17", "Midfielder", 0),
            new Players("P18", "Defender", 0),
            new Players("P19", "Midfielder", 0),
            new Players("P20", "Forward", 0),
            new Players("P21", "Midfielder", 0),
  
        };
        }
    }
}
    

