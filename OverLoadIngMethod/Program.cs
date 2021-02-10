using System;

namespace OverLoadIngMethod
{
    class Program
    {
        // methods to overload
        const double PI = 3.141593;

        // circle
        static double computeArea(double width)
        {
            double radius = width / 2;
            return ((radius * radius) * PI);
        }

        // square
        static double computeArea(double width, double height)
        {
            return width * height;
        }

        // triangle
        static double computeArea(double width, double height, char nonSenseLetter)
        {
            return ((width / 2) * height);
        }

        static void Main(string[] args)
        {
            Console.Title = "Overloading";

            double number;
            double area;

            // call cicrle mehtod
            Console.Write("Enter the dimentions in Feet: ");
            number = Convert.ToDouble(Console.ReadLine());  // single number use for each method
            area = computeArea(number);
            Console.WriteLine($"Circle area is {area:f4} sq.ft.");

            // call square method
            area = computeArea(number, number);
            Console.WriteLine($"Square area is {area} sq.ft.");

            // call triangle method
            area = computeArea(number, number, 'A');
            Console.WriteLine($"Triangle area is {area} sq.ft.");


            Console.WriteLine("\n\n\n");
        }
    }
}
