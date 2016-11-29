using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameSequence

    {

        public Player playerOne;
        public Player playerTwo;
        public Player playerAi;
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };




        public void StartUp()
        {
            GameIntro();
            //RunGame --> choose rounds players etc.
            //playerOne.MakeChoice();
            //playerTwo.MakeChoice();

        }

        public void RunGame()
        {
            playerOne.MakeChoice();
            playerTwo.MakeChoice();
            DecideWinner();
        }




        public void GameIntro()
        {
            Console.WriteLine("Welcome to Rock, Paper, Sissors, Lizard, Spock!");
            Console.WriteLine("This game is a variant of Rock, Paper, Scissors.");
            Console.WriteLine("Here are the rules to the game:");
            Console.WriteLine();
            Console.WriteLine("Sissors cuts Paper, Paper covers Rock, Rock Crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors \n decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and Rock crushes Scissors.");
            Console.WriteLine();
            playerOne = new Human();
            playerOne.SetName();
            Console.WriteLine("Would you like to play against Sheldon (Type: Sheldon) or another player (Type: Player name)");
            ChooseOpponent();

        }

        public void ChooseOpponent()
        {
            string playerTwoName = Console.ReadLine().ToLower();
            if (playerTwoName == "sheldon")
            {
                playerAi = new AI();
                Console.WriteLine("You have chosen to play against Sheldon, Good Luck!");
                
            }
            else
            {
                playerTwo = new Human();
                
            }

        
        }

        

        public void DecideWinner()
        {   int a = gestures.IndexOf(playerOne.playerChoice);
            int b = gestures.IndexOf(playerTwo.playerChoice);

            int d = (5 + a - b) % 5;
                    if (d == 1 || d == 3)
                    {
                        Console.WriteLine("You Win");
                    }
                    else if (d == 2 || d ==4)
                    {
                        Console.WriteLine("You Lose");
                    }
                    else if (d == 0)
                    {
                        Console.WriteLine("Tie");
         }
            
            

        }

       
        
         
           
    }
}
