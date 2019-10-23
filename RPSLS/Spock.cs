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

    }
}
