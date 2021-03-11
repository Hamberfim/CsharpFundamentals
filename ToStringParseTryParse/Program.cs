using System;

namespace ToStringParseTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // some variable to use
            decimal wkNetSalesValue = 3053.75m;
            decimal wkNetOverhead = 1303.75m;
            decimal wkNetProfit = wkNetSalesValue - wkNetOverhead;
            Console.WriteLine(" === original decimal vars using .ToString() === ");
            // convert decimal to strings
            string weekSales = wkNetSalesValue.ToString();
            string weekOverhead = wkNetOverhead.ToString();
            string weekProfit = wkNetProfit.ToString();
            Console.WriteLine(weekSales + " is a " + weekSales.GetType());
            Console.WriteLine(weekOverhead + " is a " + weekOverhead.GetType());
            Console.WriteLine(weekProfit + " is a " + weekProfit.GetType());
            Console.WriteLine();

            // Parse strings to doubles - Parse() and TryParse() are used on strings to convert a numerical string to any numerical data type
            Console.WriteLine(" === Double.Parse() === ");
            double wkSales = Double.Parse(weekSales);
            double wkOverhead = Double.Parse(weekOverhead);
            double wkProfit = Double.Parse(weekProfit);
            Console.WriteLine(wkSales + " is a " + wkSales.GetType());
            Console.WriteLine(wkOverhead + " is a " + wkOverhead.GetType());
            Console.WriteLine(wkProfit + " is a " + wkProfit.GetType());
            Console.WriteLine();

            // Parse() exception because of non-numeric charater(s)
            Console.WriteLine(" === .Parse() Exception === ");
            string lunchBill = "$12.99";
            try
            {
                decimal lunchBillDecimal = Decimal.Parse(lunchBill);
            }
            catch (Exception error)
            {
                Console.WriteLine($"Attempted 'lunchBillDecimal = Decimal.Parse(lunchBill)' where lunchBill == {lunchBill}");
                Console.WriteLine($"{error.Message}");
                Console.WriteLine($"!!! Non-Numeric charater in string !!!");
                Console.WriteLine();
            }
            finally
            {
                lunchBill = "12.99";
                decimal lunchBillDecimal = Decimal.Parse(lunchBill);
                Console.WriteLine($"Attempted 'lunchBillDecimal = Decimal.Parse(lunchBill)' where lunchBill == {lunchBill}");
                Console.WriteLine($"lunchBillDecimal = {lunchBillDecimal}");
            }
            Console.WriteLine();

            // TryParse()
            Console.WriteLine(" === Decimal.TryParse() === ");
            decimal wks;
            decimal wko;
            decimal wkp;
            Decimal.TryParse(weekSales, out wks);
            Decimal.TryParse(weekOverhead, out wko);
            Decimal.TryParse(weekProfit, out wkp);
            Console.WriteLine(wks + " is a " + wks.GetType());
            Console.WriteLine(wko + " is a " + wko.GetType());
            Console.WriteLine(wkp + " is a " + wkp.GetType());
            Console.WriteLine();

            // TryParse() fail - results in a zero value
            Console.WriteLine(" === TryParse() fail === ");
            Double breakfastPaid;
            string breakfastBill = "$3.99";  // Non-numerical charater '$'
            Double.TryParse(breakfastBill, out breakfastPaid);
            Console.WriteLine($"breakfastPaid = {breakfastPaid}");
            breakfastBill = "3.99";
            Double.TryParse(breakfastBill, out breakfastPaid);
            Console.WriteLine($"breakfastPaid = {breakfastPaid}");
            Console.WriteLine();

            // Convert.To...  Convert is used to convert any data type to any other data type
            string strNum = "10";
            int intStrNum = Convert.ToInt32(strNum);
            Console.WriteLine(intStrNum + " is a " + intStrNum.GetType());

            decimal decNum = 1.99m;
            double doubDecNum = Convert.ToDouble(decNum);
            Console.WriteLine(doubDecNum + " is a " + doubDecNum.GetType());

            double doubleNum = 3.49;
            decimal decDoubleNum = Convert.ToDecimal(doubleNum);
            Console.WriteLine(decDoubleNum + " is a " + decDoubleNum.GetType());
            Console.WriteLine();

            int intNum = 10;
            string strIntNum = Convert.ToString(intNum);
            string strDoubDecNum = Convert.ToString(doubDecNum);
            string strDecDoubleNum = Convert.ToString(decDoubleNum);
            Console.WriteLine(strIntNum + " is a " + strIntNum.GetType());
            Console.WriteLine(strDoubDecNum + " is a " + strDoubDecNum.GetType());
            Console.WriteLine(strDecDoubleNum + " is a " + strDecDoubleNum.GetType());


            Console.WriteLine("\n\n");
        }
    }
}
