using System;

namespace UserDefArray
{
    class Program
    {
        // average the student grades
        private static decimal GetAvgGrade(decimal[] grades)
        {
            decimal gradeSum = 0;
            int numOfGrades = 0;
            foreach (var grade in grades)
            {
                gradeSum += grade;
                numOfGrades++;
            }

            decimal avgGrade = gradeSum / numOfGrades;
            return avgGrade;
        }

        static void Main(string[] args)
        {
            // get input from user
            int numOfGrades = 0;  // the size of the array
            Console.WriteLine("Enter the number of grades to input for this student: ");
            try
            {
                numOfGrades = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException error)
            {
                Console.WriteLine($"{error.Message} input must be a whole number.");
            }

            decimal[] grades = new decimal[numOfGrades];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter a grade: ");

                try
                {
                    grades[i] = Convert.ToDecimal(Console.ReadLine());

                }
                catch (FormatException error)
                {
                    Console.WriteLine($"{error.Message} input must be numeric whole or decimal grade.");
                }
            }

            Console.WriteLine("=== the grades entered for this student ===");
            for (int j = 0; j < grades.Length; j++)
            {
                Console.WriteLine(grades[j]);
            }

            Console.WriteLine($"This students grade average is {Math.Round(GetAvgGrade(grades), 1)}");

            Console.WriteLine("\n\n");
        }

    }
}
