using System;

namespace rpsGameV1
{
    class Program
    {
        // tuple pattern matching - expression-bodied
        public static string RockPaperScissorsSwitch(string playerOne, string playerTwo) =>
            (playerOne, playerTwo) switch
            {
                ("rock", "paper") => "Paper Wins, rock covered by paper.",  // +1 player two
                ("rock", "scissors") => "Rock Wins, rock breaks scissors.", // +1 player one
                ("paper", "rock") => "Paper Wins, paper covers rock.",  // +1 player one
                ("paper", "scissors") => "Scissors Wins, paper is cut by scissors.",  // +1 player two
                ("scissors", "rock") => "Rock Wins, scissors are broken by rock.",  // +1 player two
                ("scissors", "paper") => "Scissors wins, scissors cut paper.",  // +1 player one
                (_, _) => "It's a tie!"  // no score
            };

        static void Main(string[] args)
        {
            Console.WriteLine(RockPaperScissorsSwitch("scissors", "rock"));
            Console.WriteLine(RockPaperScissorsSwitch("paper", "paper"));
            Console.WriteLine(RockPaperScissorsSwitch("rock", "paper"));
            Console.WriteLine(RockPaperScissorsSwitch("paper", "scissors"));
            Console.WriteLine();



            Console.WriteLine("\n\n");
        }

    }
}
