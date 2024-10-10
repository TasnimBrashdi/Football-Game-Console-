using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Football_Game_Console_Simulator.Players;

namespace Football_Game_Console_Simulator
{
    public class Team
    {
        public string Name { get; set; }
        public List<Players> Players { get; set; } = new List<Players>();

        public Team(string name)
        {
            Name = name;
        }

        public void AssignPlayers(Player playerPool)
        {
            Random random = new Random();
            var allPlayers = playerPool.playerList;
            allPlayers.Shuffle(random); 

            for (int i = 0; i < 11; i++) 
            {
                Players.Add(allPlayers[i]);
            }

        
            foreach (var player in Players)
            {
                player.Skill = random.Next(1, 101);
            }
        }

        public void PrintPlayers()
        {
            Console.WriteLine($"{Name} Players:");
            foreach (var player in Players)
            {
                Console.WriteLine($"{player.Name} - {player.Position} - (Skill: {player.Skill})");
            }
        }
    }
}
    

