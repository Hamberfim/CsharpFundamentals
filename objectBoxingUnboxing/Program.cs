using System;

namespace objectBoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal PI = 3.14m;
            object boxedPi = PI;  // boxing
            Console.WriteLine($"Decimal Data Type: {PI} HashCode: {PI.GetHashCode()}");
            Console.WriteLine($"Reference Object Data Type: {boxedPi} HashCode: {boxedPi.GetHashCode()}");
            PI = 3.140001m;
            Console.WriteLine();
            Console.WriteLine($"Change decimal pi value to {PI}");
            Console.WriteLine($"Decimal Data Type: {PI} HashCode: {PI.GetHashCode()} <= new stack mem");
            Console.WriteLine($"Reference Object Data Type: {boxedPi} HashCode: {boxedPi.GetHashCode()} <= original ref");
            decimal PiUnboxed = (decimal)boxedPi;
            Console.WriteLine($"BoxedPi: {boxedPi} HashCode: {boxedPi.GetHashCode()}, PiUnboxed: {PiUnboxed} HashCode: {PiUnboxed.GetHashCode()}");

            Console.WriteLine("\n\n");
        }
    }
}
