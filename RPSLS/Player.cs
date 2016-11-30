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

        public void SetPlayerOneName()
        {
           Console.WriteLine("What is your Name Player One?"); 
           playerName = Console.ReadLine();   
        }
        public void SetPlayerTwoName()
        {
            Console.WriteLine("What is your name Player Two?");
            Player.playerName = Console.ReadLine();
        }
        public virtual void MakeChoice()
        {
           
            
        }
        
    }
}
