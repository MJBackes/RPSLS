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
        private Random rng;
        int PlayerNum;
        //Constr
        public AIPlayer(int playerNum)
        {
            PlayerNum = playerNum;
            Name = "AIPlayer " + playerNum;
            IsAI = true;
            rng = new Random();
            DesyncRandoms();
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
        private void DesyncRandoms()
        {
            for(int i = GenerateRandomNumber(); i < GenerateRandomNumber()*GenerateRandomNumber()*5; i+=PlayerNum)
            {
                GenerateRandomNumber();
            }
        }
    }
}
