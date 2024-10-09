using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Game_Console_Simulator
{
    public class Team
    {
        public string NameTeam { get; set; }
        public List<Players> Teams { get; set; }
        public Team(string NameTeam) { 
        this.NameTeam = NameTeam;   
        this.Teams = new List<Players>();
        
        
        }
    }
}
