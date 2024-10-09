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
        public string NameTeam { get; set; }
        public List<string> Team1 { get; set; }
        public List<string> Team2 { get; set; }
        public int Skill;

        public enum Position
        {
            Forward, Midfielder, Defender
        }

        public Dictionary<string, Position> PlayerPositions { get; set; }

        public Team(string nameTeam)
        {
            this.NameTeam = nameTeam;
            this.Team1 = new List<string>();
            this.Team2 = new List<string>();
            this.PlayerPositions = new Dictionary<string, Position>();
        }

        public void AddPlayersToTeams(Players playerList)
        {
            List<string> allPlayers = new List<string>(playerList.players);
            Random random = new Random();

            while (allPlayers.Count > 0)
            {
                int randomIndex = random.Next(allPlayers.Count);
                string selectedPlayer = allPlayers[randomIndex];
                allPlayers.RemoveAt(randomIndex);

                if (Team1.Count <= Team2.Count)
                {
                    Team1.Add(selectedPlayer);
                }
                else
                {
                    Team2.Add(selectedPlayer);
                }
            }

        }


        //public void RandomPosition()
        //{
        //    Random random = new Random();

        //    foreach (var player in Team1)
        //    {
        //        Position randomPosition = (Position)random.Next(Enum.GetNames(typeof(Position)).Length);
        //        PlayerPositions[player] = randomPosition; 
        //    }

        //    foreach (var p in PlayerPositions)
        //    {
        //        Console.WriteLine($"{p.Key}: {p.Value}");
        //    }
        //}
        public void DisplayTeams()
        {
            Console.WriteLine($"Team: {NameTeam}");
            Console.WriteLine("\nTeam 1 Players:");
            foreach (var player in Team1)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("\nTeam 2 Players:");
            foreach (var player in Team2)
            {
                Console.WriteLine(player);
            }
        }
    }
}
