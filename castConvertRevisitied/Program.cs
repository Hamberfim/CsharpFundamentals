using System;

namespace castConvertRevisitied
{
    class Program
    {
        static void Main(string[] args)
        {
            // convertion technique choice depends on if changing the values data type will result in:

            // throwing an exception at run time:
            // int first = 2;
            // string second = "4";
            // int result = first + second;  // will trow exception at run time | CS0029: Cannot implicitly convert type 'string' to 'int'
            // Console.WriteLine(result);

            int first = 2;
            string second = "4";
            // set the data type to string instead of int for concatenation
            // implicitly performed the conversion from int to string and concatenate instead of addition
            string result2 = first + second;  // result is 24 but was that the intended result
            Console.WriteLine(result2);
            // if addition is needed then more explicit control of the process of data conversion must be done
            int result1 = first + Convert.ToInt32(second);
            Console.WriteLine(result1);
            int one = 1;
            int two = 2;
            // explicit convertion control 
            string message = one.ToString() + two.ToString();  // concat results in 12
            Console.WriteLine(message);
            // explicit convertion control 
            string five = "5";
            string seven = "7";
            int sum = int.Parse(five) + int.Parse(seven);  // addition result in 12 but what if the values coudlnt be converted to int
            Console.WriteLine(sum);
            // explicit convertion control with bool/TryParse()
            string strSix = "Six";
            int numStrSix;
            int total1;
            bool isConvertable1 = int.TryParse(strSix, out numStrSix);
            if (isConvertable1)
            {
                total1 = numStrSix + numStrSix;
                Console.WriteLine(total1);
            }
            else
            {
                Console.WriteLine($"{isConvertable1}, unable to convert to int");
            }

            string six = "6";
            int numSix;
            int total2;
            if(int.TryParse(six, out numSix))
            {
                total2 = numSix + numSix;
                Console.WriteLine(total2);
            }
            else
            {
                Console.WriteLine(int.TryParse(six, out numSix));  // results prints false if TryParse() is false
            }

            // or result in a loss of information:
            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;  // casting to int
            Console.WriteLine($"int: {myInt} <-- loss of precision - narrowing conversion");

            decimal myDecimal2 = 1.23456789m;
            float myFloat = (float)myDecimal2;

            Console.WriteLine($"Decimal: {myDecimal2}");
            Console.WriteLine($"Float: {myFloat} <-- loss of precision - narrowing conversion");

            int value = (int)1.5m; // casting truncates
            Console.WriteLine($"{value} <-- truncates - loss of precision - narrowing conversion");

            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine($"{value2} <-- rounds up - loss of precision - narrowing conversion");

            Console.WriteLine("\n\n");
        }
    }
}
