using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //MembVars
        public List<Gesture> GestureList;
        public List<string> GestureNames;
        public int RoundsToTWin;
        //Constr
        public Game(int roundsToWin)
        {
            RoundsToTWin = roundsToWin;
            GestureList = new List<Gesture> { new Rock(),new Paper(),
                new Scissors(),new Lizard(), new Spock()};
            GestureNames = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        }
        //MembMeth
        public void DisplayRules()
        {

        }
    }
}
