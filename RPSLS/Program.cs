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
            Game game = new Game();
            AIPlayer AI1 = new AIPlayer();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(AI1.ChooseGesture(game.GestureNames).Name);
            }
            Player P1 = new HumanPlayer("Me");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(P1.ChooseGesture(game.GestureNames).Name);
            }

            Console.ReadLine();
        }
    }
}
