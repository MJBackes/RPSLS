using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //MembVars
        public string Name;
        //Constr

        //MembMeth
        abstract public Gesture ChooseGesture(List<string> gestureNames);
    }
}
