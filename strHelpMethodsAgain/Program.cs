using System;

namespace strHelpMethodsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            //  identify and isolate information in a string using string helper methods
            string stringPhrase = "Locate what is inside the parentheses (John Marston) and print to the console.";
            Console.WriteLine(stringPhrase);
            Console.WriteLine();

            int openingPosition = stringPhrase.IndexOf('(');
            int closingPosition = stringPhrase.IndexOf(')');

            Console.WriteLine($"Opening parenthese position: {openingPosition}");
            Console.WriteLine($"Closing parenthese position: {closingPosition}");
            Console.WriteLine();

            int length = closingPosition - openingPosition;
            Console.WriteLine("int length = closingPosition - openingPosition;");
            Console.WriteLine($"length: {length}");
            Console.WriteLine("stringPhrase.Substring(openingPosition + 1, length - 1)");
            Console.WriteLine();

            Console.WriteLine(stringPhrase.Substring(openingPosition + 1, length - 1));
            Console.WriteLine("\n");

            // html string -  return the full address with city, state, zip to the console
            string htmlCode = "<p>Iowa Motor Vehicle Division<br>6310 SE Convenience Blvd.<br>Ankeny, Iowa 50021</p>";
            Console.WriteLine(htmlCode);
            Console.WriteLine();

            const string brTag = "<br>";
            const string closedPTag = "</p>";
            int brLength = brTag.Length;
            int closedPtagLength = closedPTag.Length;

            int firstBr = htmlCode.IndexOf("<br>");
            int secondBr = htmlCode.LastIndexOf("<br>");
            int lastP = htmlCode.IndexOf("</p>");
            Console.WriteLine($"first <br> position: {firstBr}");
            Console.WriteLine($"second <br> position: {secondBr}");
            Console.WriteLine($"closed </p> position: {lastP}");
            Console.WriteLine();

            firstBr += brLength;
            int streetAddLength = secondBr - firstBr;
            Console.WriteLine($"Street address length: {streetAddLength}");

            secondBr += brLength;
            int cityStateZipLenght = lastP - secondBr;
            Console.WriteLine($"City to zip length: {cityStateZipLenght}");
            Console.WriteLine();

            string dotFullAddr = "";
            string streetAddr = htmlCode.Substring(firstBr, streetAddLength);
            Console.WriteLine(streetAddr);
            dotFullAddr += streetAddr;

            string cityZip = htmlCode.Substring(secondBr, cityStateZipLenght);
            Console.WriteLine(cityZip);
            dotFullAddr += ", ";
            dotFullAddr += cityZip;
            Console.WriteLine();
            Console.WriteLine(dotFullAddr);

            Console.WriteLine("\n");
        }
    }
}
