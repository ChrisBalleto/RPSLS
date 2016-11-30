using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game

    {
        
        public Player playerOne;
        public Player playerTwo;
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };
        public void StartUp()
        {
            GameIntro();            
        }


        public void RunGame()
        {   
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
                DecideWinner();
            }
            OneSecondBreak();
            RoundOver();
            PlayAgain();
            Environment.Exit(0);
        }

        public void OneSecondBreak()
        {
            System.Threading.Thread.Sleep(1000);
        }

        public void ThreeSecondBreak()
        {
            Console.WriteLine("Screen will clear in 3 Seconds");
            System.Threading.Thread.Sleep(3000);
        }

        private void RoundOver()
        {
            Console.WriteLine("The round is over, Thanks for playing!");
            Console.WriteLine();
            GetScore();
        }

        private void PlayAgain()
        {
            Console.WriteLine("Would you like to play again (yes or no)?");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "yes":
                case "ok":
                    Console.WriteLine(" Great {0} ! Lets Do It!!!", playerOne.playerName);
                    ClearScores();
                    ChooseOpponent();
                    break;
                case "no":
                    Console.WriteLine("Ok, Thanks for playing see you next time!");
                    break;
                default:
                    break;
            }
        }

        public void ClearScores()
        {
            playerOne.score = 0;
            playerTwo.score = 0;
        }

        public void GetScore()
        {
            Console.WriteLine("{2} Score: {1}   {3} Score: {0}", playerTwo.score, playerOne.score, playerOne.playerName, playerTwo.playerName);
        }

        public void GameIntro()
        {
            Console.WriteLine("Welcome to Rock, Paper, Sissors, Lizard, Spock!");
            Console.WriteLine("This game is a variant of Rock, Paper, Scissors.");
            OneSecondBreak();
            Console.WriteLine();
            Console.WriteLine("Here are the rules to the game:");
            Console.WriteLine();
            OneSecondBreak();
            Console.WriteLine("Sissors cuts Paper, Paper covers Rock, Rock Crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors \n decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and Rock crushes Scissors.");
            Console.WriteLine();
            OneSecondBreak();
            playerOne = new Human();
            playerOne.SetName();            
            ChooseOpponent();
        }

        public void ChooseOpponent()
        {
            Console.WriteLine("Would you like to play against Sheldon (Type: Sheldon) or another player <ENTER>?");
            string playerTwoName = Console.ReadLine().ToLower();
            if (playerTwoName == "sheldon")
            {
                playerTwo = new AI();
                playerTwo.playerName = "Sheldon";
                
                Console.WriteLine("You have chosen to play against Sheldon, Good Luck!");
            }
            else 
            {
                playerTwo = new Human();
                Console.WriteLine("Player Two - ");
                playerTwo.SetName();
            }
            RunGame();
        }

        //public List<string> gestures = new List<string> { "rock", "paper", "scissors", "spock", "lizard" }; ----->   This is here just for a reference to the "gestures" List

        public void DecideWinner()
        {
            int playerOneChoice = gestures.IndexOf(playerOne.playerChoice);
            int playerTwoChoice = gestures.IndexOf(playerTwo.playerChoice);

            int result = (5 + playerOneChoice - playerTwoChoice) % 5;
            if (result == 1 || result == 3)
            {
                playerOne.GetGesture();
                playerTwo.GetGesture();
                Console.WriteLine("{0} Wins", playerOne.playerName);
                playerOne.PlayerGetsPoint();               
                GetScore();
                Console.WriteLine();
            }
            else if (result == 2 || result == 4)
            {
                playerOne.GetGesture();
                playerTwo.GetGesture();
                Console.WriteLine("{0} Wins", playerTwo.playerName);
                playerTwo.PlayerGetsPoint();               
                GetScore();
                Console.WriteLine();
            }
            else if (result == 0)
            {
                playerOne.GetGesture();
                playerTwo.GetGesture();
                Console.WriteLine("Tie");
                GetScore();
                Console.WriteLine();
            }
        }

        public void DisplayGestureForSheldon()
        {
            if (playerTwo.playerName == "Sheldon")
            {
                Console.WriteLine("Sheldon Had {0}!", playerTwo.playerChoice);
            }

        }
                 
    }
}
