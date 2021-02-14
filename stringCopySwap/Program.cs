using System;

namespace stringCopySwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Copy and Swap";

            string car1 = "Ghibli";
            string car2 = "GrandTurismo";

            Console.WriteLine("Original:");
            Console.WriteLine($"Car1: {car1}, Car2: {car2}");

            car1 = String.Copy(car2);
            Console.WriteLine("Copied:");
            Console.WriteLine($"Car1: {car1}, Car2: {car2}");

            int num = car1.Length;
            char[] model = new char[num];
            car1.CopyTo(0, model, 0, num);
            Console.WriteLine("Character Array:");
            foreach(char c in model)
            {
                Console.Write(c + " ");
            }



            Console.WriteLine("\n\n\n");
        }
    }
}
