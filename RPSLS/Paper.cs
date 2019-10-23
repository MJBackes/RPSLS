using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Paper : Gesture
    {
        //MembVars

        //Constr
        public Paper()
        {
            GesturesIBeat = new List<string> { "Rock", "Spock" };
            Name = "Paper";
        }
        //MembMeth
        public override void PrintVictoryText(Gesture gesture)
        {
            switch (gesture.Name)
            {
                case "Rock":
                    Console.WriteLine("Paper covers Rock.");
                    break;
                case "Spock":
                    Console.WriteLine("Paper disproves Spock.");
                    break;
                default:
                    break;
            }
        }
    }
}
