using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human: Player
    {
        public string playerOneName;
        public override void SetName()
        {
            Console.Write("Please Enter Your Name:");
            playerOneName = Console.ReadLine();
        }
        public override void MakeChoice()
        {
            Console.WriteLine("Please choose a gesture (Rock, Paper, Scissors, Lizard, or Spock)");
            string playerChoice = Console.ReadLine().ToLower();

            if (playerChoice == "rock")
            {

            }
            else if (playerChoice == "paper")
            {

            }
            else if (playerChoice == "scissors")
            {

            }
            else if (playerChoice == "spock")
            {

            }
            else if (playerChoice == "lizard")
            {

            }
            else
            {
                Console.WriteLine("Please Choose a proper Gesture");
            }   
            

        }
    }
}
