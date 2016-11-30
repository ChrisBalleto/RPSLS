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
            Console.WriteLine("Please choose a gesture {0} (Rock, Paper, Scissors, Lizard, or Spock) then hit <ENTER>", playerName);
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
            ShortBreakAndWarning();
            Console.Clear();
        }

        public void ShortBreakAndWarning()
        {
            Console.WriteLine("Screen will clear in a moment for next turn");
            System.Threading.Thread.Sleep(1100);
        }
    }
}
