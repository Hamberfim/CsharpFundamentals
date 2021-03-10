/***************************************************************
* Name        : convertMethodsFormattedStrings
* Author      : Anthony Hamlin
* Created     : 03/08/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : More converting/formatting        
***************************************************************/
using System;

namespace convertMethodsFormattedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1451.48;
            decimal interest = 0.03289m;
            int quantity = 12548;
            decimal measurement = 325.33239m;

            // currency convertion methods and ways to output/display
            Console.WriteLine(amount + " <-- initial var value");
            Console.WriteLine($"The amount: {amount:C}");
            string mounthlyAmount = amount.ToString("C");  
            Console.WriteLine("The monthly amount: " + mounthlyAmount);

            // String.Format() example - works the same with all the formatting codes below
            string payAmount = String.Format("{0:C}", amount);
            Console.WriteLine("String.Format() method: " + payAmount);

            Console.WriteLine();  // space in output

            // percent convertion methods and ways to output/display
            Console.WriteLine(interest + " <-- initial var value");
            Console.WriteLine($"The interest: {interest:p1}");  // percent to one decimal places
            string interestRate = interest.ToString("p2");  // percent to two decimal places
            Console.WriteLine("The interest rate: " + interestRate);

            Console.WriteLine();  // space in output

            // number-count convertion methods and ways to output/display
            Console.WriteLine(quantity + " <-- initial var value");
            Console.WriteLine($"The quantity: {quantity:n0}");  // thousands seperator with 0 (zero) decimal places
            string quantityCount = quantity.ToString("n0");
            Console.WriteLine("The quantity count: " + quantityCount);

            Console.WriteLine();  // space in output

            // float convertion methods and ways to output/display
            Console.WriteLine(measurement + " <-- initial var value");
            Console.WriteLine($"The measurement: {measurement:f3}");  // float with three decimal places
            string measurementPrecision = measurement.ToString("f4");  // float with four decimal places
            Console.WriteLine("The precision measurement: " + measurementPrecision);

            Console.WriteLine();  // space in output

            // rgb values for basic blue RGB(0, 0, 255) hex is #0000FF
            int rRGB = 0;
            int gRGB = 0;
            int bRGB = 255;
            // hex convertion methods and ways to output/display
            Console.WriteLine($"RGB({rRGB}, {gRGB}, {bRGB}) <-- initial RGB var values for blue");
            Console.WriteLine($"Just the blue rgb channel of {bRGB}: #{bRGB.ToString("x")}");  // no prefix zeros
            Console.WriteLine($"The hex color: #{bRGB.ToString("x6")}");  // prefix zeros for a total of 6 hex position
            string hexFromRGB = $"RGB({rRGB}, {gRGB}, {bRGB}) to hex is #{rRGB.ToString("x2")}{gRGB.ToString("x2")}{bRGB.ToString("x")}";  // x2 = prefix zeros for rgb values of zero
            Console.WriteLine(hexFromRGB);

            Console.WriteLine("\n\n");
        }
    }
}
