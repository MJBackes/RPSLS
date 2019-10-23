using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Spock : Gesture
    {
        //MembVars
        //Constr
        public Spock()
        {
            GesturesIBeat = new List<string> { "Scissors", "Rock" };
            Name = "Spock";
        }
        //MembMeth
        public override void PrintVictoryText(Gesture gesture)
        {
            switch (gesture.Name)
            {
                case "Rock":
                    Console.WriteLine("Spock vaporizes Rock.");
                    break;
                case "Scissors":
                    Console.WriteLine("Spock smashes Scissors.");
                    break;
                default:
                    break;
            }
        }
    }
}
