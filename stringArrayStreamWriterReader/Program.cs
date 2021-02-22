using System;
using System.IO;

namespace stringArrayStreamWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);

            path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path)));
            Console.WriteLine(path);

            path = $"{path}\\myStringFile.txt";
            Console.WriteLine(path);



            Console.WriteLine("\n\n\n");
        }
    }
}
