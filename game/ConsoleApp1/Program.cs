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
            Console.WriteLine("Hi, press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            Game game = new Game();
            game.StartGame();
        }
    }
}
