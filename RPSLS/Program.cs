using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game;
            bool continuePlaying = false ;
            string input;
            do
            {
                continuePlaying = false;
                Console.Clear();
                game = new Game();
                Console.WriteLine("1:Display Rules.");
                Console.WriteLine("2:Start");
                Console.WriteLine("Enter 1 to see the rules, 2 to start.");
                input = (Console.ReadLine());
                switch (input)
                {
                    case "1":
                        game.DisplayRules();
                        Console.ReadLine();
                        continuePlaying = true;
                        break;
                    case "2":
                        game.StartGame();
                        break;
                    default:
                        break;
                }
                if (continuePlaying)
                {
                    continue;
                }
                do
                {
                    Console.WriteLine("Continue? 'Y'/'N'");
                    input = Console.ReadLine().ToLower();
                } while (input != "y" && input != "n");
                if(input == "y")
                {
                    continuePlaying = true;
                }
                else
                {
                    continuePlaying = false;
                }
                Console.ReadLine();
            } while (continuePlaying);
        }
    }
}
