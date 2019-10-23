using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Rock : Gesture
    {
        //MembVars

        //Constr
        public Rock()
        {
            GesturesIBeat = new List<string> { "Scissors", "Lizard" };
            Name = "Rock";
        }
        //MembMeth
        public override void PrintVictoryText(Gesture gesture)
        {
            switch (gesture.Name)
            {
                case "Lizard":
                    Console.WriteLine("Rock crushes Lizard.");
                    break;
                case "Scissors":
                    Console.WriteLine("Rock crushes Scissors.");
                    break;
                default:
                    break;
            }
        }
    }
}
