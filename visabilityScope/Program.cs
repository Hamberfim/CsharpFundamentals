using System;

// namespace visability
namespace visabilityScope
{
    // class visability
    class Program
    {
        static void Main(string[] args)
        {
            // Code blocks impact the scope of a variable declaration
            // i.e., the visibility of the variable to code in the application
            int numbers = 123456789;
            int reverseOrdernums = ReverseOrderNums(numbers);
            Console.WriteLine($"Our starting number was {numbers}. Pass thru same class method, ReverseOrdernums makes them {reverseOrdernums}");
            Console.WriteLine();

            int newNumber = 92345789;
            // visability is acheived by using the class name to call the method since it doesn't live in the same 'Program' class
            int revNewNumbers = Reversing.ReverseOrderNums(newNumber);
            Console.WriteLine($"Our starting number was {newNumber}. Pass thru different class, Reversing.ReverseOrderNums makes them {revNewNumbers}");
            Console.WriteLine();

            int nameSpaceNumber = 912345699;
            // visability is acheived by using the class name to call the method since it doesn't live in the same 'Program' class
            int namespaceNumbers = Reverser.Reversing.ReverseOrderNums(nameSpaceNumber);
            Console.WriteLine($"Our starting number was {nameSpaceNumber}. Pass thru different namespace class, Reverser.Reversing.ReverseOrderNums makes them {namespaceNumbers}");
            Console.WriteLine();

            Console.WriteLine("\n\n");
        }

        static int ReverseOrderNums(int someNumbers)
        {
            string strNumbers = Convert.ToString(someNumbers);
            char[] strNumbersArr = strNumbers.ToCharArray();
            Array.Reverse(strNumbersArr);
            string reversedStr = new string(strNumbersArr);
            int revNumbers = Convert.ToInt32(reversedStr);
            return revNumbers;
        }
    }

    // moved to it's own class - class visability
    class Reversing
    {
        // public so it's assessable/visable to the main() method in the Program Class
        public static int ReverseOrderNums(int someNumbers)
        {
            string strNumbers = Convert.ToString(someNumbers);
            char[] strNumbersArr = strNumbers.ToCharArray();
            Array.Reverse(strNumbersArr);
            string reversedStr = new string(strNumbersArr);
            int revNumbers = Convert.ToInt32(reversedStr);
            return revNumbers;
        }
    }
}

// move to it's own namespace - namespace visability
namespace visabilityScope.Reverser
{
    // moved to it's own class - class visability
    class Reversing
    {
        // public so it's assessable/visable to the main() method in the Program Class
        public static int ReverseOrderNums(int someNumbers)
        {
            string strNumbers = Convert.ToString(someNumbers);
            char[] strNumbersArr = strNumbers.ToCharArray();
            Array.Reverse(strNumbersArr);
            string reversedStr = new string(strNumbersArr);
            int revNumbers = Convert.ToInt32(reversedStr);
            return revNumbers;
        }
    }
}
