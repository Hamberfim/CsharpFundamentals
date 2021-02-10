using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Methods";

            static void bodyTempC()
            {
                Console.WriteLine("Body Temperature");
                Console.WriteLine("Centigrade:\t37C");
            }

            static double bodyTempF()
            {
                // local scope var
                double temperature = 98.6;
                return temperature;
            }

            static int bodyTempK()
            {
                // local scope var
                int temperature = 310;
                return temperature;
            }

            // call the methods
            bodyTempC();
            Console.WriteLine($"Fahrenheit:\t{bodyTempF()}F");
            Console.WriteLine("Kelvin:\t" + bodyTempK() + "K");


            Console.ReadKey();
        }
    }
}
