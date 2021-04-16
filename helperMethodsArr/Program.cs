using System;

namespace helperMethodsArr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13", "A12", "A15", "B15", "A10", "B10", "B11", "A14", "B13"};
            Console.WriteLine($"Pallet Count: {pallets.Length}");
            Console.WriteLine();

            Console.WriteLine("Sorted...");
            // The Array class has methods that can manipulate the size and contents of an array
            Array.Sort(pallets);  // sort method of the Array class - in place method has no return (so it's return type is void ?)  
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine();

            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);  // sort method of the Array class - in place method has no return (so it's return type is void ?)
            foreach (var pallete in pallets)
            {
                Console.WriteLine($"-- {pallete}");
            }
            Console.WriteLine();

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing first 2 in reversed()... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine();

            Console.WriteLine("Add Building Location Id ...");
            Action<string> action = new Action<string>(withLocationCode);
            Array.Sort(pallets);
            Array.ForEach(pallets, action);
            Console.WriteLine();

            Console.WriteLine("Resize Array (enlarge)...");
            Console.WriteLine($"Current Pallet Count: {pallets.Length}");
            Array.Resize(ref pallets, 14);
            Console.WriteLine($"Resizing 14 ... new count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine();
            Console.WriteLine("Add values to the empty index positions of the resized array..");
            pallets[0] = "Z09";
            pallets[1] = "Z10";
            pallets[12] = "C10";
            pallets[13] = "C11";
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine();

            Console.WriteLine("Resize Array (reduce)...");
            Console.WriteLine($"Pallet Count: {pallets.Length}");
            Array.Resize(ref pallets, 11);
            Console.WriteLine($"Resizing 11 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine();

            // remove null elements from the array
            string[] locIds = {"z7", "z3", "z2", "z6", "z4", "z5"};
            Console.WriteLine("challenge - remove null elements...");
            Console.WriteLine($"Count: {locIds.Length}");
            foreach (var locId in locIds)
            {
                Console.WriteLine($"-- {locId} ");
            }
            Console.WriteLine();

            Array.Clear(locIds, 1, 2);
            Console.WriteLine($"Count: {locIds.Length}");
            foreach (var locId in locIds)
            {
                Console.WriteLine($"-- {locId} ");
            }
            Console.WriteLine();

            // count the number of non-null elements
            int nonNullCount = 0;
            foreach (var locId in locIds)
            {
                if(locId != null)
                {
                    nonNullCount++;
                }
            }
            // use the non-null count as the lenght of a new array
            string[] newLocIds = new string[nonNullCount];
            // loop through each element in the original array and copy non-null values into the new array
            int indx = 0;  // track index position to populate new array
            for (int i = 0; i < locIds.Length; i++)
            {
                if(locIds[i] != null)
                {
                    newLocIds[indx] = locIds[i];
                    indx++; 
                }
            }
            Console.WriteLine("New Array based on non-null items...");
            foreach (var item in newLocIds)
            {
                Console.WriteLine($"-- {item}");
            }
            Console.WriteLine();



            Console.WriteLine("\n\n");
        }


        public static void withLocationCode(string value)
        {
            if(value == null)
            {
                // the C# Compiler implicitly converts the null value to an empty string for presentation
                Console.WriteLine($"-- {value}-NULL-implicitly converts to EMPTY-STRING");

                // if we attept to call a method on the contents of 'value' prior to the compiler we would get a NullReferenceException
                /* i.e., Console.WriteLine($"-- {value.ToLower()}"); */
                // because the C# compiler hasn't implicitly converted the null to an empty string yet
            }
            else
            {
                Console.WriteLine($"-- {value}-BldLocId-A-03");
            }
            
        }
    }
}
