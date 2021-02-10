using System;

namespace MethodsValueRef
{
    class Program
    {

        private static void SetShoeSizeByValue(decimal shoeSize)
        {
            Console.WriteLine($"{shoeSize}' shoe size within scope of SetShoeSizeByValue");
            shoeSize = shoeSize * 2.54M;  // convert from inches to cm
            Console.WriteLine($"{shoeSize} cm shoe size after conversion within scope of SetShoeSizeByValue");
  
        }

        private static void SetShoeSizeByRef(ref decimal shoeSize)
        {
            Console.WriteLine($"{shoeSize}' shoe size within scope of SetShoeSizeByRef");
            shoeSize = shoeSize * 2.54M;  // convert from inches to cm
            Console.WriteLine($"{shoeSize} cm shoe size after conversion within scope of SetShoeSizeByRef");

        }

        static void Main(string[] args)
        {
            decimal shoeSize = 10;
            Console.WriteLine($"{shoeSize}' shoe size within scope of main");
            Console.WriteLine();

            // pass method argument by value
            SetShoeSizeByValue(shoeSize);
            Console.WriteLine($"{shoeSize}' shoe size after conversion SetShoeSizeByValue method call but within scope of main");
            Console.WriteLine();

            // pass method argument by ref 
            SetShoeSizeByRef(ref shoeSize);
            Console.WriteLine($"{shoeSize} cm shoe size after conversion SetShoeSizeByRef method call but within scope of main");


            Console.WriteLine("\n\n\n");
        }
    }
}
