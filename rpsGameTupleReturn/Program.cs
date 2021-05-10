using System;

namespace rpsGameTupleReturn
{
    class Program
    {
        // tuple pattern matching and tuple return
        private static (string winMessage, string whoScored) RockPaperScissors(string playerOne, string playerTwo) => (playerOne, playerTwo) switch
        {
            ("rock", "paper") => ("Paper Wins, rock covered by paper.", "playerTwo"),  // +1 player two
            ("rock", "scissors") => ("Rock Wins, rock breaks scissors.", "playerOne"), // +1 player one
            ("paper", "rock") => ("Paper Wins, paper covers rock.", "playerOne"),  // +1 player one
            ("paper", "scissors") => ("Scissors Wins, paper is cut by scissors.", "playerTwo"),  // +1 player two
            ("scissors", "rock") => ("Rock Wins, scissors are broken by rock.", "playerTwo"),  // +1 player two
            ("scissors", "paper") => ("Scissors wins, scissors cut paper.", "playerOne"),  // +1 player one
            (_, _) => ("It's a tie!", "No Score")  // no score
        };

        // from each round a give a player a score
        private static void givePoint(ref int playerOneScore, ref int playerTwoScore, (string winMessage, string whoScored) roundThrow)
        {
            if (roundThrow.whoScored.Contains("playerOne"))
            {
                playerOneScore += 1;
            }
            else if (roundThrow.whoScored.Contains("playerTwo"))
            {
                playerTwoScore += 1;
            }
            else
            {
                playerOneScore += 0;
                playerTwoScore += 0;
            }
        }

        static void Main(string[] args)
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;

            // return is a tuple whos members are winMessage & whoScored
            var roundThrow = RockPaperScissors("rock", "paper");
            // reference members score
            Console.WriteLine(roundThrow.winMessage);
            givePoint(ref playerOneScore, ref playerTwoScore, roundThrow);

            roundThrow = RockPaperScissors("scissors", "rock");
            // reference members score
            Console.WriteLine(roundThrow.winMessage);
            givePoint(ref playerOneScore, ref playerTwoScore, roundThrow);

            roundThrow = RockPaperScissors("paper", "paper");
            // reference members score
            Console.WriteLine(roundThrow.winMessage);
            givePoint(ref playerOneScore, ref playerTwoScore, roundThrow);

            roundThrow = RockPaperScissors("paper", "scissors");
            // reference members score
            Console.WriteLine(roundThrow.winMessage);
            givePoint(ref playerOneScore, ref playerTwoScore, roundThrow);

            Console.WriteLine($"Player One: {playerOneScore} Vs Player Two: {playerTwoScore}");

            Console.WriteLine("\n\n");
        }
 
    }
}
