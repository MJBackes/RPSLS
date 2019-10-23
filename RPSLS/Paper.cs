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

    }
}
