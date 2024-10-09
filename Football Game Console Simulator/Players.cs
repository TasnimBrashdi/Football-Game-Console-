using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Football_Game_Console_Simulator.Players;

namespace Football_Game_Console_Simulator
{
    public class Players
    {
        public string names;
        public enum Position
        {
            Forward, Midfielder, Defender
        }
        public Position position;
        public int Skill;
        public Players(string names, Position position, int Skill)
        {
            this.names = names;
            this.position = position;
            this.Skill = Skill;
        }
    }
 
}
