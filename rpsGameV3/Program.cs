/***************************************************************
* Name        : Rock Paper Scissors
* Author      : Anthony Hamlin
* Created     : 05/07/2021
* Version     : 3.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Simple Rock, Paper, Scissors game      
***************************************************************/
using System;

namespace rpsGameV3
{
    class Program
    {
        // Computer Player random choice
        private static string PlayerTwoThrow()
        {
            Random rnd = new Random();
            int playerTwoChoice = rnd.Next(1, 4);
            string playerTwoToss;

            if (playerTwoChoice == 1)
            {
                playerTwoToss = "rock";
                return playerTwoToss;
            }
            else if (playerTwoChoice == 2)
            {
                playerTwoToss = "paper";
                return playerTwoToss;
            }
            else
            {
                playerTwoToss = "scissors";
                return playerTwoToss;
            }
            
        }

        // Human Players input choice
        private static string PlayerOneThrow(int playerOneChoice)
        {
            string playerOneToss;

            if (playerOneChoice == 1)
            {
                playerOneToss = "rock";
                return playerOneToss;
            }
            else if (playerOneChoice == 2)
            {
                playerOneToss = "paper";
                return playerOneToss;
            }
            else
            {
                playerOneToss = "scissors";
                return playerOneToss;
            }
        }

        // determin throw winner - game logic
        private static void RockPaperScissors(ref string playerOneToss, ref string playerTwoToss, ref int playerOneScore, ref int playerTwoScore)
        {
            if (playerOneToss.Contains("rock") && playerTwoToss.Contains("paper"))
            {
                Console.WriteLine("Paper Wins, rock covered by paper.");
                playerTwoScore += 1;
            }
            else if (playerOneToss.Contains("rock") && playerTwoToss.Contains("scissors"))
            {
                Console.WriteLine("Rock Wins, rock breaks scissors.");
                playerOneScore += 1;
            }
            else if (playerOneToss.Contains("paper") && playerTwoToss.Contains("rock"))
            {
                Console.WriteLine("Paper Wins, paper covers rock.");
                playerOneScore += 1;
            }
            else if (playerOneToss.Contains("paper") && playerTwoToss.Contains("scissors"))
            {
                Console.WriteLine("Scissors Wins, paper is cut by scissors.");
                playerTwoScore += 1;
            }
            else if (playerOneToss.Contains("scissors") && playerTwoToss.Contains("rock"))
            {
                Console.WriteLine("Rock Wins, scissors are broken by rock.");
                playerTwoScore += 1;
            }
            else if (playerOneToss.Contains("scissors") && playerTwoToss.Contains("paper"))
            {
                Console.WriteLine("Scissors wins, scissors cut paper.");
                playerOneScore += 1;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        static void Main(string[] args)
        {
            // keep track of player scores
            int playerOneScore = 0;
            int playerTwoScore = 0;

            bool playAgain = true;
            do
            {
                // get player two(computer) RPS throw
                string computerPlayer = PlayerTwoThrow();

                // get player one Rock, Paper, Scissors hand throw
                Console.Write("Choose 'Rock'(1), 'Paper'(2), 'Scissor'(3): ");
                try
                {
                    int playerOneChoice = Convert.ToInt32(Console.ReadLine());
                    // is the input between 1 and 3 
                    if (playerOneChoice >= 1 && playerOneChoice <= 3)
                    {
                        string humanPlayer = PlayerOneThrow(playerOneChoice);

                        // run game
                        Console.WriteLine($"Player One({humanPlayer}), Computer({computerPlayer})");
                        RockPaperScissors(ref humanPlayer, ref computerPlayer, ref playerOneScore, ref playerTwoScore);
                        Console.WriteLine($"Player One score: {playerOneScore}, Computer score: {playerTwoScore}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Input must be the number 1, 2, or 3. i.e., 'Rock'(1), 'Paper'(2), 'Scissor'(3)");
                    }
                    
                }
                catch (Exception error)
                {
                    Console.WriteLine($"{error} Input must be the number 1, 2, or 3.");
                }

                // continue playing ??
                Console.Write("Want to play again? (Y)es or anything else to exit: ");
                try
                {
                    string again = Console.ReadLine().ToLower();
                    if (again.Contains("y"))
                    {
                        playAgain = true;
                        Console.WriteLine();
                    }
                    else
                    {
                        playAgain = false;
                        Console.WriteLine("Not a yes response. EXITING PROGRAM");
                        Console.WriteLine();
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine($"{error} Input must be (Y)es or (N)o");
                }
            } while (playAgain);

            // determine final score
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine($"Player one is the WINNER! Player one score: {playerOneScore} vs Computer score: {playerTwoScore}");
            }
            else if (playerOneScore < playerTwoScore)
            {
                Console.WriteLine($"Player two is the WINNER! Player one score: {playerOneScore} vs Computer score: {playerTwoScore}");
            }
            else
            {
                Console.WriteLine($"NO WINNER! We have a Tie match! Player one score: {playerOneScore} vs Computer score: {playerTwoScore}");
            }

            Console.WriteLine("\n\n");
        }

        
    }
}
