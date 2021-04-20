using System;

namespace workingWithDataFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int invoiceNumber = 1201;
            decimal productMeasurement = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            // alignment
            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
            Console.WriteLine($"     Sub Total: {subtotal:C}");
            Console.WriteLine($"           Tax: {taxPercentage:P2}");
            Console.WriteLine($"     Total Due: {total:C}");

            // padding and alignment - add white space
            Console.WriteLine();
            string itemToFormat = "pad";
            Console.WriteLine(itemToFormat);
            // makes the string 10 chars by adding 7 char spaces to the left of the word 'pad'
            Console.WriteLine($"{itemToFormat.PadLeft(10)}");
            Console.WriteLine($"{itemToFormat.PadRight(10)}");

            // overload the method - add white space or other characters
            Console.WriteLine($"{itemToFormat.PadLeft(10, '-')}");
            Console.WriteLine($"{itemToFormat.PadRight(10, '-')}");
            Console.WriteLine($"{itemToFormat.PadLeft(10, '.')}");
            Console.WriteLine($"{itemToFormat.PadRight(10, '.')}");
            Console.WriteLine();

            // examples
            string paymentId = "A9-769-009";  // char count is 10
            Console.WriteLine(paymentId.Length);
            Console.WriteLine();

            string payeeName = "Mr. Bill Chalupa";  // char count 16
            Console.WriteLine(payeeName.Length);
            Console.WriteLine();

            var formattedLine = paymentId.PadRight(15, '.');  // add an addition 5 chars to the right 
            formattedLine += payeeName.PadRight(21, '.');  // add an additional 5 chars to the right

            Console.WriteLine(formattedLine);
            Console.WriteLine();

            // with out space indicators/overload method
            paymentId = "A9-844-013";  // char count is 10
            payeeName = "Mrs. Lucinda Bertoni";  // char count is 20
            string paymentAmount = "$5,000.00";  // char count is 9

            formattedLine = paymentId.PadRight(17);  // add 7 additional spaces to the right
            formattedLine += payeeName.PadRight(20);  // not actually adding any spaces
            formattedLine += paymentAmount.PadLeft(16);  // adding 7 spaces to the LEFT to create the padding

            Console.WriteLine(formattedLine);  // From above (17+20+16=53) total line length is 53
            Console.WriteLine($"formattedLine length: {formattedLine.Length}");
            Console.WriteLine();

            // example
            string idTitle = "PaymentID:";
            string nameTitle = "Name:";
            string amountTitle = "Amount:";
            string formatedTitles = "";
            formatedTitles += idTitle.PadRight(17);
            formatedTitles += nameTitle.PadRight(27);
            formatedTitles += amountTitle;

            Console.WriteLine(formatedTitles);
            Console.WriteLine(formattedLine);

            Console.WriteLine("\n");
        }
    }
}
