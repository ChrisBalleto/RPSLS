using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI: Player
    {
        public string aiGesture;
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };

        public override void MakeChoice()
        {
            Random choice = new Random();
            aiGesture = choice.Next(gestures.Length);
            
        }
    }
}
