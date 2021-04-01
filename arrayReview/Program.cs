using System;


namespace arrayReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid guidGood = Guid.NewGuid();  // create a Guid value

            var guidInBytes = guidGood.ToByteArray();  // as a byte array
            string guidInStr = guidGood.ToString();  // as a string

            Console.WriteLine($"GUID: {guidGood}");
            Console.WriteLine($"As String: {guidInStr}");
            Console.Write("As Bytes: ");
            foreach (var bit in guidInBytes)
            {
                Console.Write($"{bit:X2} ");  // output of the byte array
            }
            var guidGood2 = new Guid(guidInBytes);  // instantiates a new Guid value from the byte array
            Console.WriteLine();
            Console.WriteLine($"Back to GUID: {guidGood2}");
            Console.WriteLine($"First GUID: {guidGood}. GUID from byte array: {guidGood2}.");
            Console.WriteLine($"IS SAME: {guidGood2.Equals(guidGood)}");
            Console.WriteLine();
            Console.WriteLine();

            // ids for an array of guids
            Guid id0 = Guid.NewGuid();
            Guid id1 = Guid.NewGuid();
            Guid id2 = Guid.NewGuid();

            Guid[] guidOrderIDs = {id0, id1, id2};
            for (int i = 0; i < guidOrderIDs.Length; i++)
            {
                Console.WriteLine($"ID {i}: {guidOrderIDs[i]}");
            }
            Console.WriteLine();

            // reassign guidOrderIDs[0]
            guidOrderIDs[0] = Guid.NewGuid();
            Console.WriteLine($"Reassigned ID 0: {guidOrderIDs[0]}");
            Console.WriteLine();

            // ouput after reassignment
            int idCount = 0;
            foreach (var ids in guidOrderIDs)
            {
                Console.WriteLine($"ID {idCount}: {ids}");
                idCount++;
            }
            
            Console.WriteLine("\n\n");
        }
    }
}
