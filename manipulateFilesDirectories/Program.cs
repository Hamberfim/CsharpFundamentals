using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace manipulateFilesDirectories
{
    
    class Program
    {
        static double CalculateSalesTotal(IEnumerable<string> salesFiles)
        {
            double salesTotal = 0;

            // Loop over each file path in salesFiles
            foreach (var file in salesFiles)
            {
                // Read the contents of the file
                string salesJson = File.ReadAllText(file);

                // Parse the contents as JSON
                SalesData data = JsonConvert.DeserializeObject<SalesData>(salesJson);

                // Add the amount found in the Total field to the salesTotal variable
                salesTotal += data.Total;
                
            }

            return salesTotal;
        }

        class SalesData
        {
            public double Total { get; set; }
        }

        class InventoryData
        {
            public double Sodapop { get; set; }
        }

        // function to find all the sales.json files in the 'stores' folder and sub folders
        static IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();

            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
            {
                var extension = Path.GetExtension(file);

                if (extension == ".json")
                    salesFiles.Add(file);
            }

            return salesFiles;
        }

        static void Main(string[] args)
        {
            // get current dir
            var currentDirectory = Directory.GetCurrentDirectory();
            // Console.WriteLine(currentDirectory);

            // Project directory - up three directories
            string projDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(currentDirectory)));  // each call goes up its parent directory
            // Console.WriteLine(projDir);

            var storesDirectory = Path.Combine(projDir, "stores"); // directory to search in
            // Console.WriteLine(storesDirectory);

            // the top directory to search for sales.json files
            var salesFiles = FindFiles(storesDirectory);

            // lists all the found json files
            foreach (var file in salesFiles)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine();

            // new dir to write totals to
            var salesTotalDir = Path.Combine(projDir, "salesTotalDir");
            Directory.CreateDirectory(salesTotalDir);

            // call to read all the sales data in the directories
            var salesTotal = CalculateSalesTotal(salesFiles);
            Console.WriteLine($"Total sales: {salesTotal:N2}");

            // write the file
            File.WriteAllText(Path.Combine(salesTotalDir, "salesTotals.txt"), $"Total Sales: {salesTotal:N2}{Environment.NewLine}");
            Console.WriteLine();

            // read inventory files
            var invJsonRaw201 = File.ReadAllText($"{storesDirectory}{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}inventory.json");
            var invJsonData201 = JsonConvert.DeserializeObject<InventoryData>(invJsonRaw201);

            var invJsonRaw202 = File.ReadAllText($"{storesDirectory}{Path.DirectorySeparatorChar}202{Path.DirectorySeparatorChar}inventory.json");
            var invJsonData202 = JsonConvert.DeserializeObject<InventoryData>(invJsonRaw202);

            var invJsonRaw203 = File.ReadAllText($"{storesDirectory}{Path.DirectorySeparatorChar}203{Path.DirectorySeparatorChar}inventory.json");
            var invJsonData203 = JsonConvert.DeserializeObject<InventoryData>(invJsonRaw203);

            var invJsonRaw204 = File.ReadAllText($"{storesDirectory}{Path.DirectorySeparatorChar}204{Path.DirectorySeparatorChar}inventory.json");
            var invJsonData204 = JsonConvert.DeserializeObject<InventoryData>(invJsonRaw204);

            // total the inventory data
            var inventoryTotal = invJsonData201.Sodapop + invJsonData202.Sodapop + invJsonData203.Sodapop + invJsonData204.Sodapop;
            Console.WriteLine($"Remaining Inventory:{inventoryTotal}");

            // new dir to write inventory totals to
            var inventoryTotalDir = Path.Combine(projDir, "inventoryTotalDir");
            Directory.CreateDirectory(inventoryTotalDir);

            // write the file
            File.WriteAllText(Path.Combine(inventoryTotalDir, "inventoryTotals.txt"), $"Remaining inventory: {inventoryTotal}{Environment.NewLine}");


            Console.WriteLine("\n");
        }
    }
}
