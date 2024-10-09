using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Football_Game_Console_Simulator
{
    public class Game
    {
        public Team Team1 { get; set; } 
        public Team Team2 { get; set; } 
        public int Score { get; set; }
        public enum Posititon
        {
            Attack,Defender
        }
        public Posititon posititon { get; set; }
        public string Half;
        public Game(Team team)
        {
   
            Score = 0; 
        }

        public void CoinToss()
        {
            Random random = new Random();
            int choice = random.Next(0, 2); 
            Team selectedTeam = (choice == 0) ? Team1 : Team2;
            Console.WriteLine("Selected team: " + selectedTeam);
        }


    }
}
