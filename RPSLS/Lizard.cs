using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Lizard : Gesture
    {
        //MembVars

        //Constr
        public Lizard()
        {
            GesturesIBeat = new List<string> { "Spock", "Paper" };
            Name = "Lizard";
        }
        //MembMeth
        public override void PrintVictoryText(Gesture gesture)
        {
            switch (gesture.Name)
            {
                case "Spock":
                    Console.WriteLine("Lizard poisons Spock.");
                    break;
                case "Paper":
                    Console.WriteLine("Lizard eats Paper.");
                    break;
                default:
                    break;
            }
        }
    }
}
