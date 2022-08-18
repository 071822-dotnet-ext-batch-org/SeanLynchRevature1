using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            //made an object of a class (lowercase game is the object, the uppercase is the class)
            Console.WriteLine("player1 please enter your name");
            string playername = Console.ReadLine();
            Player player1 = new Player();
            player1.name = playername;
            Player player2 = new Player();
            player2.name = "computer";
            game.playthegame(player1, player2);
            Console.ReadLine();
        }
    }
}
