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
        
    }
}
