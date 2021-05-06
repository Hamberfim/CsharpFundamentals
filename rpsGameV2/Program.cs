/***************************************************************
* Name        : Rock Paper Scissors
* Author      : Anthony Hamlin
* Created     : 05/06/2021
* Version     : 2.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Simple console rock, paper scissors game       
***************************************************************/
using System;

namespace rpsGameV2
{
    class Program
    {
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
            string playerOneToss;
            string playerTwoToss;
            int playerOneScore = 0;
            int playerTwoScore = 0;

            playerOneToss = "scissors"; playerTwoToss = "rock";
            Console.WriteLine($"Player One({playerOneToss}), Player Two({playerTwoToss})");
            RockPaperScissors(ref playerOneToss, ref playerTwoToss, ref playerOneScore, ref playerTwoScore);
            Console.WriteLine($"Player One score: {playerOneScore}, Player Two score: {playerTwoScore}");
            Console.WriteLine();

            playerOneToss = "scissors"; playerTwoToss = "paper";
            Console.WriteLine($"Player One({playerOneToss}), Player Two({playerTwoToss})");
            RockPaperScissors(ref playerOneToss, ref playerTwoToss, ref playerOneScore, ref playerTwoScore);
            Console.WriteLine($"Player One score: {playerOneScore}, Player Two score: {playerTwoScore}");
            Console.WriteLine();

            playerOneToss = "paper"; playerTwoToss = "rock";
            Console.WriteLine($"Player One({playerOneToss}), Player Two({playerTwoToss})");
            RockPaperScissors(ref playerOneToss, ref playerTwoToss, ref playerOneScore, ref playerTwoScore);
            Console.WriteLine($"Player One score: {playerOneScore}, Player Two score: {playerTwoScore}");
            Console.WriteLine();

            playerOneToss = "rock"; playerTwoToss = "paper";
            Console.WriteLine($"Player One({playerOneToss}), Player Two({playerTwoToss})");
            RockPaperScissors(ref playerOneToss, ref playerTwoToss, ref playerOneScore, ref playerTwoScore);
            Console.WriteLine($"Player One score: {playerOneScore}, Player Two score: {playerTwoScore}");
            Console.WriteLine();

            playerOneToss = "paper"; playerTwoToss = "scissors";
            Console.WriteLine($"Player One({playerOneToss}), Player Two({playerTwoToss})");
            RockPaperScissors(ref playerOneToss, ref playerTwoToss, ref playerOneScore, ref playerTwoScore);
            Console.WriteLine($"Player One score: {playerOneScore}, Player Two score: {playerTwoScore}");
            Console.WriteLine();

            Console.WriteLine("=== Best out of Five ===");
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player one is the winner!");
            }
            else if(playerOneScore < playerTwoScore)
            {
                Console.WriteLine("Player two is the winner!");
            }
            else
            {
                Console.WriteLine("We have a Tie match!");
            }

            Console.WriteLine("\n\n");
        }

        
    }
}
