using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI: Player
    {
        
        //public List<string> gestures = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };


        public override void MakeChoice()
        {
            Random choice = new Random();
            playerChoice = gestures[choice.Next(0,5)];
            
        }
    }
}
