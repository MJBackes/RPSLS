using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Gesture
    {
        //MembVars
        public List<string> GesturesIBeat;
        public string Name;
        //Constr

        //MembMeth
        public bool DoIBeat(Gesture gesture)
        {
            foreach (string gestureName in GesturesIBeat)
            {
                if (gestureName == gesture.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public bool DoITie(Gesture gesture)
        {
            if(gesture.Name == this.Name)
            {
                return true;
            }
            return false;
        }
    }
}
