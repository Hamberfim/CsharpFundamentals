using System;

namespace MoreMethods
{
    class Program
    {

        static void AverageOfInput(double n1, double n2, double n3)
        {
            decimal d1 = Convert.ToDecimal(n1);
            decimal d2 = Convert.ToDecimal(n2);
            decimal d3 = Convert.ToDecimal(n3);
            decimal avg = (d1 + d2 + d3) / 3M;
            // Console.WriteLine(avg.GetType());  The type is decimal but {avg:D} errors
            Console.WriteLine($"The average of {d1}, {d2}, and {d3} is {avg:F2} ");
            Console.WriteLine($"To five places is {avg:F5} ");
        }


        static void Main(string[] args)
        {
            // AverageOfInput(1.5, 2.5, 0.9);
            AverageOfInput(10.52, 20.58, 0.966664);
            // AverageOfInput(1200.55, 2000.665, 50.99999);

            Console.WriteLine("\n\n\n");
        }
    }
}
