using static Football_Game_Console_Simulator.Players;

namespace Football_Game_Console_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name for Team 1: ");
            string teamName1 = Console.ReadLine();

            Console.Write("Enter the name for Team 2: ");
            string teamName2 = Console.ReadLine();

            Team team1 = new Team(teamName1);
            Team team2 = new Team(teamName2);
            Player playerT = new Player();
        
            team1.AssignPlayers(playerT);
            team2.AssignPlayers(playerT);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            team1.PrintPlayers();
            Console.ForegroundColor = ConsoleColor.Cyan;
            team2.PrintPlayers();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Game game = new Game(team1, team2);
            //______START GAME______
            game.SartGame();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
    }
}
