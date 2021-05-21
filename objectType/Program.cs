using System;

namespace objectType
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dyn = 2 * 6;
            object obj = 2 * 5;

            // Rest the mouse pointer over dyn and obj to see their types at compile time.
            Console.WriteLine($"{dyn} is {dyn.GetType()} and dny is resolved at runtime");
            Console.WriteLine($"{obj} is {obj.GetType()} and obj is exact runtime type of current instance");

            dyn = dyn + 3; // dyn is not checked at compile time because the type of dyn is dynamic
            // obj = obj + 3; //A compiler error is reported for the attempted addition of an integer and an object in expression obj + 3

            Console.WriteLine("\n\n");
        }
    }
}
