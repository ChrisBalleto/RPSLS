using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human: Player
    {
        
        public override void MakeChoice()
        {
            Console.WriteLine("Please choose a gesture (Rock, Paper, Scissors, Lizard, or Spock)");
            playerChoice = Console.ReadLine().ToLower();
            switch (playerChoice)
            {
                case "rock":
                case "paper":
                case "scissors":
                case "spock":
                case "lizard":
                    break;
                default:
                    Console.WriteLine("Please Choose a proper Gesture");
                    MakeChoice();
                    break;
            }
           
            

        }
    }
}
