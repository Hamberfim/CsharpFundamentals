using System;

namespace Constant
{
    class Program
    {
        // enumerators must be declared outside any method block
        enum Days { Sat, Sun, Mon, Tue, Wed, Thur, Fri };

        enum Compass { North = 1, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest }

        static void Main(string[] args)
        {
            // title the console
            Console.Title = "Constants";

            // a constant and it's variable
            const double pi = 3.14159265358979;
            var daysType = typeof(Days);
            Console.WriteLine("Type: " + typeof(Days));

            Console.WriteLine("Pi data type: " + pi.GetType());
            Console.WriteLine("Circumferencd: " + (pi * 3));

            // index position of enums
            Console.WriteLine("First Day index name is: " + Days.Sat);
            Console.WriteLine("First Day index position is: " + (int)Days.Sat);

            // display second position enum (of zero indexed itemes) and query the enum list
            string name = Enum.GetName(daysType, 1);
            Console.WriteLine("Second Day index name is: " + name);
            Console.WriteLine("Second Day index position is: " + (int)Days.Sun);
            bool flag = Enum.IsDefined(daysType, "Mon");
            Console.WriteLine("Enum List Containes Mon?: " + flag);

            Console.WriteLine("Press space bar to exit this program.");

            Console.ReadKey();

        }
    }
}
