using System;

namespace strHelpMethodsAgain2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "(What if) there are (more than) one (set of parentheses) that we want (info from)?";
            Console.WriteLine(message);
            Console.WriteLine();

            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) // IndexOf() returns -1 if it can't find a match.
                {
                    break;
                }
                else
                {
                    openingPosition += 1;

                    int closingPosition = message.IndexOf(')');

                    int length = closingPosition - openingPosition;

                    Console.WriteLine(message.Substring(openingPosition, length));

                    // overload of Substring to return only the remaining unprocessed message:
                    // i.e., without specifying a length input parameter, it will return every character after the starting position you specify
                    message = message.Substring(closingPosition + 1);
                }

            }

            Console.WriteLine();
            string message2 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
            Console.WriteLine(message2);
            Console.WriteLine();

            // The IndexOfAny() helper method requires a char array of characters to look for:
            char[] openSymbols = { '[', '{', '(' };

            // We'll use a slightly different technique for iterating through the 
            // characters in the string.  This time, we'll use the closing position
            // of the previous iteration as the starting index for the next open
            // symbol.  So, we need to initialize the closingPosition variable
            // to zero:
            int closingPosition2 = 0;

            while (true)
            {
                // IndexOfAny() will return the first match it finds in the string
                int openingPosition2 = message2.IndexOfAny(openSymbols, closingPosition2);

                if (openingPosition2 == -1)  // IndexOfAny() returns -1 if it can't find a match.
                {
                    break;
                }
                else 
                {
                    string currentSymbol = message2.Substring(openingPosition2, 1);

                    // Now we must find the matching closing symbol
                    char matchingSymbol = ' ';

                    switch (currentSymbol)
                    {
                        case "[":
                            matchingSymbol = ']';
                            break;
                        case "{":
                            matchingSymbol = '}';
                            break;
                        case "(":
                            matchingSymbol = ')';
                            break;
                    }

                    // Finally, use the techniques we've already learned to display the sub-string:
                    openingPosition2 += 1;
                    closingPosition2 = message2.IndexOf(matchingSymbol, openingPosition2);

                    int length = closingPosition2 - openingPosition2;
                    Console.WriteLine(message2.Substring(openingPosition2, length));
                }

            }
            Console.WriteLine();

            string myPhrase = "I <3 connerl@otherdomain.net from connerm@exampledomain.com";
            Console.WriteLine(myPhrase);
            Console.WriteLine();
            string conner = "conner";
            int connerLength = conner.Length;

            int FirstfoundC = myPhrase.IndexOf("c");
            int firstAtSymbol = myPhrase.IndexOf("@");
            
            Console.WriteLine($"First c position: {FirstfoundC}");
            Console.WriteLine($"First @ position: {firstAtSymbol}");

            // locate first name initial right before @ symbol
            int firstInitialPosOne = firstAtSymbol - 1;
            Console.WriteLine($"First Initital position: {firstInitialPosOne}");
            Console.WriteLine($"First initial is: {myPhrase.Substring(firstInitialPosOne, 1)}.");

            // locate last name
            string initialOne = myPhrase.Substring(firstInitialPosOne, 1);
            Console.WriteLine($"Last name is: {myPhrase.Substring(FirstfoundC, connerLength)}.");

            string lastNameOne = myPhrase.Substring(FirstfoundC, connerLength);
            string fullNAmeOne = initialOne.ToUpper() + ". " + char.ToUpper(lastNameOne[0]) + lastNameOne.Substring(1).ToLower();
            Console.WriteLine($"First full name: {fullNAmeOne}");
            Console.WriteLine();

            int lastArSymbol = myPhrase.LastIndexOf("@");
            Console.WriteLine($"Last @ position: {lastArSymbol}");

            // locate first name initial right before @ symbol
            int firstInitialPosTwo = lastArSymbol - 1;
            Console.WriteLine($"Second Initital position: {firstInitialPosTwo}");
            Console.WriteLine($"Second initial is: {myPhrase.Substring(firstInitialPosTwo, 1)}.");

            // locate last name
            string initialTwo = myPhrase.Substring(firstInitialPosTwo, 1);
            string fullNAmeTwo = initialTwo.ToUpper() + ". " + char.ToUpper(lastNameOne[0]) + lastNameOne.Substring(1).ToLower();
            Console.WriteLine($"Second full name: {fullNAmeTwo}");
            Console.WriteLine();

            // remove and replace content in myPhrase "I <3 connerl@otherdomain.net from connerm@exampledomain.com"
            Console.WriteLine(myPhrase);
            // remove <3
            int firstLessThanBracket = myPhrase.IndexOf("<");
            string myPhraseUpdated = myPhrase.Remove(firstLessThanBracket, firstLessThanBracket+1);
            Console.WriteLine(myPhraseUpdated);
            myPhraseUpdated = myPhraseUpdated.Replace("connerm@exampledomain.com", fullNAmeTwo);
            Console.WriteLine(myPhraseUpdated);
            myPhraseUpdated = myPhraseUpdated.Replace("connerl@otherdomain.net", fullNAmeOne);
            Console.WriteLine(myPhraseUpdated);
            myPhraseUpdated = myPhraseUpdated.Replace("I ", "I love ");
            Console.WriteLine(myPhraseUpdated);

            Console.WriteLine();

            Console.WriteLine("\n");
        }
    }
}
