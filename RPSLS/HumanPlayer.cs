using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayer : Player
    {
        //MembVars

        //Constr
        public HumanPlayer(string name)
        {
            Name = name;
        }
        //MembMeth
        public override Gesture ChooseGesture(List<Gesture> gestures)
        {
            List<string> gestureNames = new List<string>();
            foreach(Gesture gesture in gestures)
            {
                gestureNames.Add(gesture.Name.ToLower());
            }
            string input;
            do
            {
                Console.WriteLine($"Enter the name of the gesture you want to choose,{Name}:");
                
                input = Console.ReadLine().ToLower();
            } while (!gestureNames.Contains(input));
            switch (input)
            {
                case "rock":
                    return new Rock();
                case "paper":
                    return new Paper();
                case "scissors":
                    return new Scissors();
                case "lizard":
                    return new Lizard();
                case "spock":
                    return new Spock();
                default:
                    return new Rock();
            }
        }
    }
}
