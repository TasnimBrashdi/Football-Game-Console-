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
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Half { get; set; }

        public Game(Team team1, Team team2)
        {
            Team1 = team1;
            Team2 = team2;
            Score1 = 0;
            Score2 = 0;
            Half = "First Half"; 
        }

        public void CoinToss()
        {
            Random random = new Random();
            int choice = random.Next(0, 2);
            Team selectedTeam = (choice == 0) ? Team1 : Team2;
            Console.WriteLine("Satrt Playing with Team: " + selectedTeam.Name);
        }

        public void SartGame()
        {
            Console.WriteLine("\nGame Start!");
            CoinToss();

            for (int half = 1; half <= 2; half++)
            {
                Half = half == 1 ? "First Half" : $"Second Half{Console.ForegroundColor = ConsoleColor.Magenta}";
                Console.WriteLine($"\n{Half} LET'S START TO BEGINS!");

                for (int turn = 0; turn < 5; turn++) 
                {
                    Attack(Team1, Team2);
                    Attack(Team2, Team1);
                }
            }

            Console.WriteLine($"Final Score: {Team1.Name} {Score1} - {Team2.Name} {Score2}");
            if (Score2 > Score1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{Team2.Name} IS WINNER!");
            }
            else if (Score1 > Score2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{Team1.Name} IS WINNER!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It's a draw!");
            }
        }

        private void Attack(Team attackingTeam, Team defendingTeam)
        {
            Random random = new Random();
            int AttackingIndex = random.Next(attackingTeam.Players.Count);
            int DefendingIndex = random.Next(defendingTeam.Players.Count);

            Players attacker = attackingTeam.Players[AttackingIndex];
            Players defender = defendingTeam.Players[DefendingIndex];
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{attacker.Name} Attack ___VS___ {defender.Name} Defense");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
 
            if (attacker.Skill-10 > defender.Skill)
            {
                Console.WriteLine($"{attacker.Name} scores!");
                if (attackingTeam == Team1) Score1++;
                else Score2++;
            }
            else
            {
                Console.WriteLine($"{defender.Name} successfully defends! ");
            }
        }
    }

    public static class ListExtensions
    {
        public static void Shuffle<T>(this IList<T> list, Random random)
        {
            int n = list.Count;
            while (n > 1)
            {
                int k = random.Next(n--);
                T temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
        }
    }
}