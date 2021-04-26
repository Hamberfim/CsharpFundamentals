using System;
using System.Collections;

namespace interfaceIterator
{
    class Program
    {
        // simple
        public static IEnumerable MyTitles()
        {
            yield return "Mr.";
            yield return "Mrs.";
            yield return "Ms";
            yield return "Mx.";
            yield return "Dr.";
        }

        // collection class
        public class HonorTitles : IEnumerable
        {
            private string[] titles = { "Lord", "Lady", "Duke", "Dutches", "Earl", "Countess" };

            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < titles.Length; i++)
                {
                    yield return titles[i];
                }
            }
        }


        static void Main(string[] args)
        {
            // IEnumerable MyTitles()
            foreach (var title in MyTitles())
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            // HonorTitles : IEnumerable
            HonorTitles titles = new HonorTitles();
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine("\n");
        }
    }
}
