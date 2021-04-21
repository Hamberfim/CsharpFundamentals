using System;

namespace strHelpMethodsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            add code to extract, replace, and remove portions of the input's value to produce this desired output:

            Quantity: 5000
            Output: <h2>Widgets &reg;</h2><span>5000</span >

            */

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here
            string openSpanTag = "<span>";
            string closeSpanTag = "</span>";
            int openSpanLength = openSpanTag.Length;
            int closeSpanLength = closeSpanTag.Length;


            //grab quantity value
            int openSpanPos = input.IndexOf(openSpanTag);
            int closeSpanPos = input.IndexOf(closeSpanTag);
            int quantityStartPos = openSpanPos + openSpanLength;
            int quantityLength = closeSpanPos - quantityStartPos;
            quantity = input.Substring(quantityStartPos, quantityLength);

            // remove t from &trade
            string inputUpdate = input.Replace("&trade", "&reg");

            // remove <div> and </div>
            string openDivTag = "<div>";
            int openDivLength = openDivTag.Length;
            int openDivPos = input.IndexOf(openDivTag);
            inputUpdate = inputUpdate.Remove(openDivPos, (openDivPos + openDivLength));

            string closedDivTag = "</div>";
            int closedDivPos = inputUpdate.IndexOf(closedDivTag);
            output = inputUpdate.Remove(closedDivPos);

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");

            Console.WriteLine("\n");
        }
    }
}
