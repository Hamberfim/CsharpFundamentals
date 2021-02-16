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

            Console.WriteLine();  // need a new line

            car1 = car1.Remove(5);
            Console.WriteLine("Removed...\tCar1: " + car1);

            car1 = car1.Insert(0, "Maserati ");  // insert at beginning
            car1 = car1.Insert(14, " Cabrio");  // insert at end
            Console.WriteLine("Inserted...\tCar1: " + car1);

            car1 = car1.Replace("Grand Cabrio", "Quattroporte");  // must match
            Console.WriteLine("Replaced...\tCar1: " + car1);

            car1 = car1.Replace("Maserati Quattroporte", "Rusty POS!");
            Console.WriteLine("Replaced...\tCar1: " + car1 + " is worse than a " + car2);

            Console.WriteLine();  // need a new line
            Console.WriteLine();  // space

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            int charArrayLength = name.Length;  // get the length of the input name
            char[] nameArray = new char[charArrayLength];  // create array same length as input name
            name.CopyTo(0, nameArray, 0, charArrayLength);  // copy the name into the array
            Console.WriteLine("You entered: " + name + ", the system sees it as a " + name.GetType() + " data type.");
            Console.WriteLine("A character array of your name:");
            foreach(char c in nameArray)
            {
                Console.Write(c + " ");  // output the each cahr in the array on a line
            }


            Console.WriteLine("\n\n\n");
        }
    }
}
