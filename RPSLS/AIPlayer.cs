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
        //Constr
        public AIPlayer(int playerNum)
        {
            Name = "PLayer " + playerNum;
            IsAI = true;
        }
        //MembMeth
        public override Gesture ChooseGesture(List<Gesture> gestures,Random rng)
        {
            switch (GenerateRandomNumber(rng))
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
        private int GenerateRandomNumber(Random rng)
        {
            return rng.Next(1, 6);
        }
    }
}
