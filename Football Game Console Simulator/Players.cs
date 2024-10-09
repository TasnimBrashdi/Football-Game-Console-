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
        public string[] players= { "P1","P2","P3","P4","P5","P6","P7","P8","P9","P10","P11","P12","P13","P14","P15","P16","P17","P18","P19","P20","P21"};
        public enum Position
        {
            Forward, Midfielder, Defender
        }
        public Position position;
        public int Skill;
        public Players( Position position, int Skill)
        {
    
            this.position = position;
            this.Skill = Skill;
        }
        public void randomPosition()
        {
            Dictionary<string, Position> playerPositions = new Dictionary<string, Position>();

   
            Random random = new Random();

            foreach (var player in players)
            {
      
                Position randomPosition = (Position)random.Next(Enum.GetNames(typeof(Position)).Length);
                playerPositions[player] = randomPosition;
            }

    
            foreach (var entry in playerPositions)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        public void randomSkill()
        {
            Dictionary<string, int> playerPositions = new Dictionary<string, int>();
            Random random = new Random();
            // Generate a random integer
            int randomNumber = random.Next();
            int randomInRange = random.Next(1, 101); 
            Console.WriteLine("Random number: " + randomNumber);
            Console.WriteLine("Random number between 1 and 99: " + randomInRange);
         

            foreach (var player in players)
            {

                int randomSkill = (int)random.Next(Enum.GetNames(typeof(int)).Length);
                playerPositions[player] = randomSkill;
            }


            foreach (var entry in playerPositions)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
    }
    

