using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Game_Console_Simulator
{
    public class Game
    {
        public string team1;
        public string team2;
        public int score;
        public enum Posititon
        {
            Attack,Defender
        }
        public Posititon posititon { get; set; }
        public string Half;


    }
}
