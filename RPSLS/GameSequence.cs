using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class GameSequence

    {
        public string playerTwoName;
        public Player playerOne;
        public Player playerTwo;
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };
        public void StartUp()
        {
            GameIntro();
            //RunGame --> choose rounds players etc.
            //playerOne.MakeChoice();
            //playerTwo.MakeChoice();

        }

        //public void GetNumberOFRounds()
        //{
        //    int rounds = Console.ReadLine();
        //        if (rounds % 2 == 0)
        //    {
        //        (rounds =+ 1 =/ 2);
        //    }
        //        else if ( rounds % 2 != 0 )
        //    {

        //    }

        //}
        public void RunGame()
        {   
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
                DecideWinner();

            }
            GetScore();
            RoundOver();
            PlayAgain();
            Environment.Exit(0);
        }

        private void RoundOver()
        {
            Console.WriteLine("The round is over, Thanks for playing!");
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
                    Console.WriteLine(" Great {0} ! Lets Do It!!!");
                    ChooseOpponent();
                    break;
                case "no":
                    Console.WriteLine("Ok, Thanks for playing see you next time!");
                    break;
                default:
                    break;
            }
        }

        public void GetScore()
        {
            Console.WriteLine("Player One Score: {1}   Player Two Score: {0}", playerTwo.score, playerOne.score);
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
            playerOne.SetPlayerOneName();            
            ChooseOpponent();
        }
        public void ChooseOpponent()
        {
            Console.WriteLine("Would you like to play against Sheldon (Type: Sheldon) or another player <ENTER>?");
            playerTwoName = Console.ReadLine().ToLower();
            if (playerTwoName == "sheldon")
            {
                playerTwo = new AI();
                playerTwo.playerName = "Sheldon";
                
                Console.WriteLine("You have chosen to play against Sheldon, Good Luck!");
            }
            else 
            {
                playerOne = new Human();
                playerTwo = new Human();
                playerTwo.SetPlayerTwoName();
            }
            RunGame();
        }



        public void DecideWinner()
        {
            int playerOneChoice = gestures.IndexOf(playerOne.playerChoice);
            int playerTwoChoice = gestures.IndexOf(playerTwo.playerChoice);

            int result = (5 + playerOneChoice - playerTwoChoice) % 5;
            if (result == 1 || result == 3)
            {
                Console.WriteLine("{0} Wins", playerOne.playerName);
                playerOne.PlayerGetsPoint();
                DisplayGestureIfSheldonWins();
                GetScore();
                Console.WriteLine();
            }
            else if (result == 2 || result == 4)
            {
                Console.WriteLine("{0} Wins", playerTwo.playerName);
                playerTwo.PlayerGetsPoint();
                DisplayGestureIfSheldonWins();
                GetScore();
                Console.WriteLine();
            }
            else if (result == 0)
            {
                Console.WriteLine("Tie");
                GetScore();
                Console.WriteLine();
            }
        }
        public void DisplayGestureIfSheldonWins()
        {
            if (playerTwo.playerName == "Sheldon")
            {
                Console.WriteLine("Sheldon Had {0}!", playerTwo.playerChoice);
            }

        }
                 
    }
}
