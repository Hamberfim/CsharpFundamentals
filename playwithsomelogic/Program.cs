using System;

namespace playwithsomelogic
{
    class Program
    {
        // enumerators must be declared outside any method block
        enum Compass { North = 1, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest }

        static void Main(string[] args)
        {
            // some more practise with enum and logic control
            Console.WriteLine();  // space for output

            int i = 3;
            do
            {
                // user input with a do/while, if/else and switch case
                Console.Write("Enter a choice(a number from 1-8): ");
                string userchoice = Console.ReadLine();
                Compass compass = (Compass)Convert.ToInt32(userchoice);  //convert input for enum

                Compass choice = (Compass)int.Parse(userchoice);  // another convertion method
                // Console.WriteLine($"Your Choice was {choice}");

                if ((int)choice == 1)
                {
                    Console.Write("North then...");
                }
                else if ((int)choice == 5)
                {
                    Console.Write("South then...");
                }
                else if ((int)choice == 2 ^ (int)choice == 3 ^ (int)choice == 4)
                {
                    Console.Write("An Easterly direction then...");
                }
                else if ((int)choice == 6 ^ (int)choice == 7 ^ (int)choice == 8)
                {
                    Console.Write("A Westerly direction then...");
                }
                else
                {
                    Console.Write("You didn't follow the instructions.");
                }


                Console.WriteLine();  // space for output

                switch (compass)
                {
                    case Compass.North:
                        Console.WriteLine(compass + " is where you are headed.");
                        break;
                    case Compass.NorthEast:
                        Console.WriteLine(compass + " is where you are headed.");
                        break;
                    case Compass.East:
                        Console.WriteLine(compass + " is where you are headed.");
                        break;
                    case Compass.SouthEast:
                        Console.WriteLine(compass + " is where you are headed.");
                        break;
                    case Compass.South:
                        Console.WriteLine(compass + " is where you are headed.");
                        break;
                    case Compass.SouthWest:
                        Console.WriteLine(compass + " is where you are headed.");
                        break;
                    case Compass.West:
                        Console.WriteLine(compass + " is where you are headed.");
                        break;
                    case Compass.NorthWest:
                        Console.WriteLine(compass + " is where you are headed.");
                        break;
                    default:
                        Console.WriteLine("Your choice was not in the range of nummers to choose from.");
                        break;
                }
                Console.WriteLine();  // space for output

                i--;
                if (i > 0)
                {
                    Console.WriteLine($"Lets' try this {i} more times.");
                }
                else
                {
                    Console.WriteLine("Press space bar to exit this program.");
                }

            }
            while (i > 0);

            Console.ReadKey();
        }
    }
}
