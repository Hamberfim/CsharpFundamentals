using System;

namespace dataValueRefTypesRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types - A value type variable will store its values directly in an area of storage called the stack
            // Signed integral Type represent an equal number of positive and negative numbers
            Console.WriteLine("Signed integral Types represent an equal number of positive and negative numbers:");
            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
            Console.WriteLine();

            // Unsigned integral Type represent only positive numbers
            Console.WriteLine("Unsigned integral Types represent only positive numbers:");
            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine();

            // "E notation", a form of scientific notation, means "times ten raised to the power of".
            // So a value like 5E+2 would be the value 500 because it's the equivalent of 5 * 10^2, or 5 * 10 * 10
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
            Console.WriteLine();

            // Reference Types - A reference type variable will store its values in a separate memory region called the heap
            int[] dataOne;  // Because it's not pointing to a memory address of a value in the heap, it's a null reference.

            int[] dataTwo;
            dataTwo = new int[3];  // the default int array value of zero is actually stored in the heap but it's memory address in the heap is stored in the variable dataTwo not the actual value
            // alternatively int[] dataTwo = new int[3];


            Console.WriteLine("\n\n");
        }
    }
}
