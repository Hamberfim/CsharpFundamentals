using System;

namespace arrHelperChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Word reversal
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] splitPang = pangram.Split(" ");
            string[] reversedPang = new string[splitPang.Length];

            for (int i = 0; i < splitPang.Length; i++)
            {
                char[] strPangLetterArr = splitPang[i].ToCharArray();
                Array.Reverse(strPangLetterArr);
                reversedPang[i] = new string(strPangLetterArr);
            }

            string newPangram = String.Join(" ", reversedPang);
            Console.WriteLine(newPangram);

            Console.WriteLine("\n\n");
        }
    }
}
