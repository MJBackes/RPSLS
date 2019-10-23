using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AIPlayer : Player
    {
        //MembVars
        Random rng;
        //Constr
        public AIPlayer()
        {
            Name = "PLayer 2";
            rng = new Random();
        }
        //MembMeth
        public override Gesture ChooseGesture(List<Gesture> gestures)
        {
            switch (GenerateRandomNumber())
            {
                case 1:
                    return new Rock();
                case 2:
                    return new Paper();
                case 3:
                    return new Scissors();
                case 4:
                    return new Lizard();
                case 5:
                    return new Spock();
                default:
                    return new Rock();
            }
        }
        private int GenerateRandomNumber()
        {
            return rng.Next(1, 6);
        }
    }
}
