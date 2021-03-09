﻿using System;

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

            // Parse strings to doubles
            Console.WriteLine(" === Double.Parse() === ");
            double wkSales = Double.Parse(weekSales);
            double wkOverhead = Double.Parse(weekOverhead);
            double wkProfit = Double.Parse(weekProfit);
            Console.WriteLine(wkSales + " is a " + wkSales.GetType());
            Console.WriteLine(wkOverhead + " is a " + wkOverhead.GetType());
            Console.WriteLine(wkProfit + " is a " + wkProfit.GetType());
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

            // Convert.To...
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
