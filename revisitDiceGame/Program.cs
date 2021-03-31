/***************************************************************
* Name        : revisitDiceGame
* Author      : Anthony Hamlin
* Created     : 03/31/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : Looping 3-dice roll game with bonus points on double and triple rolls       
***************************************************************/
using System;

namespace revisitDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // introduction
            Console.WriteLine(" ====== One Toss 3-Dice Game ======");

            bool again = true;
            while (again)
            {
                Random rnd = new Random();

                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1, 7);
                int roll3 = rnd.Next(1, 7);
                int score = roll1 + roll2 + roll3;
                Console.WriteLine($" \n Dice Roll Score: {roll1} + {roll2} + {roll3} = {score}");
                Console.WriteLine();

                // check for triple rolls
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine($" You rolled triples! +5 bonus points");
                    score += 5;
                }
                // check for double rolls
                else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
                {
                    Console.WriteLine($" You rolled doubles! +2 bonus points");
                    score += 2;
                }

                // checking for winning score and super score (above max of three sixes)
                if ((score >= 15) && (score <= 18))
                {
                    Console.WriteLine($" Your Score is {score}. We have a winner!");
                }
                else if(score > 18)
                {
                    Console.WriteLine($" WINNER! WINNER! Your Score is {score}. Because of bonus points you have a score over 18. ");
                }
                else
                {
                    Console.WriteLine($" Your Score is {score}, sorry you lose. You need at least 15 points to win.");
                }

                // play again
                Console.WriteLine();
                Console.WriteLine(" \n Want to play again? Enter (Y)es or (N)o:");
                string answer = Console.ReadLine();
                answer.ToLower();

                if (answer.Contains("y"))
                {
                    again = true;
                }
                else
                {
                    // anything other than 'y'
                    again = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine(" Thanks for playing. Exiting Program.");

            Console.WriteLine("\n\n");
        }
    }
}
