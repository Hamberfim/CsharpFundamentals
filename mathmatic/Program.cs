using System;

namespace mathmatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arithmatic";

            int e = 8;
            int f = 4;

            Console.WriteLine($"\t{e} + {f} = " + (e + f));
            Console.WriteLine($"\t{e} - {f} = " + (e - f));
            Console.WriteLine($"\t{e} * {f} = " + (e * f));
            Console.WriteLine($"\t{e} / {f} = " + (e / f));
            Console.WriteLine($"\t{e} % {f} = " + (e % f));

            Console.WriteLine();  // space

            Console.WriteLine($"\t{e}++");
            e++;
            Console.WriteLine($"\tresult " + (e));
            Console.WriteLine();  // space

            Console.WriteLine($"\t{f}++");
            f++;
            Console.WriteLine($"\tresult = " + (f));
            Console.WriteLine();  // space

            Console.WriteLine($"\t{e}--");
            e--;
            Console.WriteLine($"\tresult " + (e));
            Console.WriteLine();  // space

            Console.WriteLine($"\t{f}--");
            f--;
            Console.WriteLine($"\tresult = " + (f));
            Console.WriteLine();  // space

            Console.WriteLine("\tAssignment in equation:");
            Console.WriteLine($"\te += f ({e} += {f}) results in f = " + (e += f));
            Console.WriteLine($"\te -= f ({e} -= {f}) results in f = " + (e -= f));
            Console.WriteLine($"\te *= f ({e} *= {f}) results in f = " + (e *= f));
            Console.WriteLine($"\te /= f ({e} /= {f}) results in f = " + (e /= f));
            Console.WriteLine($"\te %= f ({e} %= {f}) results in f = " + (e %= f));
            Console.WriteLine();  // space

            Console.WriteLine("\tComparisons:");
            Console.WriteLine($"\te == f ({e} == {f}) " + (e == f));
            Console.WriteLine($"\te != f ({e} != {f}) " + (e != f));
            Console.WriteLine($"\te > f ({e} > {f}) " + (e > f));
            Console.WriteLine($"\te < f ({e} < {f}) " + (e < f));
            Console.WriteLine($"\te <= f ({e} <= {f}) " + (e <= f));
            Console.WriteLine($"\te >= f ({e} >= {f}) " + (e >= f));
            Console.WriteLine();  // space

            bool yes = true;
            bool no = false;
            Console.WriteLine("\tAND Logic:");
            Console.WriteLine("\t\t (yes && yes): " + (yes && yes));
            Console.WriteLine("\t\t (yes && no): " + (yes && no));
            Console.WriteLine("\t\t (no && no): " + (no && no));
            Console.WriteLine("\tOR Logic:");
            Console.WriteLine("\t\t (yes || yes): " + (yes || yes));
            Console.WriteLine("\t\t (yes || no): " + (yes || no));
            Console.WriteLine("\t\t (no || no): " + (no || no));
            Console.WriteLine("\tNOT Logic:");
            Console.WriteLine("\t\t yes = " + yes);
            Console.WriteLine("\t\t !yes = " + !yes);
            Console.WriteLine("\t\t no = " + no);
            Console.WriteLine("\t\t !no = " + !no);
            Console.WriteLine();  // space

            Console.WriteLine("\tCondition: ");
            Console.WriteLine("\t\t (expression) ? if-true-return-this: if-false-return-this; ");
            Console.WriteLine("\t\t (variable !=1 ) ? if-true-do-this: if-false-do-this; ");
            Console.WriteLine("\t\t (variable % 2 != 0 ) ? its-true(odd)-do-this: its-false(even)-do-this; ");
            int a = 1;
            int b = 2;
            string verb = (a != 1) ? " are " : " is ";
            Console.WriteLine("\tThere" + verb + a);
            verb = (b != 1) ? " are " : " is ";
            Console.WriteLine("\tThere" + verb + b);
            string parity = (a % 2 != 0) ? "odd" : "even";
            Console.WriteLine("\t" + a + " is " + parity);
            parity = (b % 2 != 0) ? "odd" : "even";
            Console.WriteLine("\t" + b + " is " + parity);
            int max = (a > b) ? a : b;
            Console.WriteLine("\tMax is " + max);

            Console.ReadKey();
        }
    }
}
