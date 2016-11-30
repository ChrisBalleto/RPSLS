using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {      
        public string playerChoice;
        public int score;
        public string playerName;        
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };

        public void PlayerGetsPoint()
        {
            score++;
        }

        public void GetGesture()
        {
            Console.WriteLine("{0} had {1}", playerName, playerChoice);
        }

        public void SetName()
        {
            Console.WriteLine("What is your Name?");
            playerName = Console.ReadLine();
        }       

        public virtual void MakeChoice()
        {
             
        }
        
    }
}
