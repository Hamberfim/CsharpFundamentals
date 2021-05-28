using System;

namespace Delegates
{
    class Program
    {
        // specifies the required signature of Mean using 'arithmetic' lambda expression
        delegate double Mean(double a, double b, double c);

        static double MeanMethod(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        static void Main(string[] args)
        {
            // delegate Mean instantiated with lamba expression
            Mean lambdaMean = (a, b, c) => (a + b + c) / 3;
            // each delegate is invoked using .Invoke() method
            double lambdaMeanResult = lambdaMean.Invoke(3, 4.5, 5);
            Console.WriteLine($"instantiated with lamba expression: {lambdaMeanResult}");

            // named method
            Mean mean = MeanMethod;
            // each delegate is invoked using .Invoke() method
            double meanResult = mean.Invoke(3, 4.5, 5);
            Console.WriteLine($"named method: {meanResult}");

            // anonymous method signature of Mean using 'geometric' return expression
            Mean anonymousMean = delegate (double a, double b, double c)
            {
                return (a + b + c) / 3;
            };
            // each delegate is invoked using .Invoke() method
            double anonymousMeanResult = anonymousMean.Invoke(3, 4.5, 5);
            Console.WriteLine($"anonymous method: {anonymousMeanResult}");

            Console.WriteLine("\n\n");
        }
    }
}
