using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Scissors : Gesture
    {
        //MembVars

        //Constr
        public Scissors()
        {
            GesturesIBeat = new List<string> { "Paper", "Lizard" };
            Name = "Scissors";
        }
        //MembMeth
        public override void PrintVictoryText(Gesture gesture)
        {
            switch (gesture.Name)
            {
                case "Paper":
                    Console.WriteLine("Scissors cuts Paper.");
                    break;
                case "Lizard":
                    Console.WriteLine("Scissors decapitates Lizard.");
                    break;
                default:
                    break;
            }
        }
    }
}
