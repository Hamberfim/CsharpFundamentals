using System;

namespace twoDArr
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D array matrix
            int[,] twoDintArr = {
                {100, 200},
                {300, 400},
                {500, 600},
                {700, 800},
                {900, 1000},
                {1100, 1200},
                {1300, 1400},
                {1500, 1600}
            };

            Console.WriteLine("==============");
            Console.WriteLine("== 2D Array ==");
            Console.WriteLine("==============");
            for (int indx1 = 0; indx1 < twoDintArr.GetLength(0); indx1++)
            {
                for (int indx2 = 0; indx2 < twoDintArr.GetLength(1); indx2++)
                {
                    // if at the last item (right column, last row) in the 2d array- dont add the comma
                    if((indx1 == twoDintArr.GetLength(0) - 1) && (indx2 == twoDintArr.GetLength(1) - 1))
                    {
                        Console.Write($" {twoDintArr[indx1, indx2]} ");
                    }
                    else
                    {
                        Console.Write($" {twoDintArr[indx1, indx2]}, ");
                    }
                    
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            // Console.WriteLine();



            Console.WriteLine("\n\n");
        }
    }
}
