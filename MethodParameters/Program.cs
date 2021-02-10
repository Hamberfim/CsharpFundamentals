using System;

namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // example provided
            Console.Title = "Method Parameters";

            double weight;
            string number;

            static string getWeight(out double theWeight)
            {
                theWeight = 10;
                return "Ten";
            }

            static double lbToKg(double pounds = 5)
            {
                return (pounds * 0.45359273);
            }

            static void kgToLb(ref double weight)
            {
                weight = (weight / 0.45359273);
            }

            number = getWeight(out weight);
            Console.WriteLine(number + " lb = " + lbToKg(weight) + " kg");

            kgToLb(ref weight);
            Console.WriteLine(number + " kg = " + weight + " lb");
            Console.WriteLine(); // space

            // my practice examples
            static string setUserInfo(string fname, string lname, string address="Des Moines Metro, IA", string dept="N/A")
            {
                string fn = fname;
                string ln = lname;
                string addr = address;
                string dpt = dept;

                return $"Employee: {fn} {ln}, Address: {addr} Department: {dpt}.";
            }

            Console.WriteLine("========= setUserInfo Method==========");
            // Console.WriteLine(setUserInfo("Bill", "Clastanelli", "419 SW Porter Dr., Des Moines, IA 50266", "Marketing"));
            string ClastanelliB = setUserInfo("Bill", "Clastanelli", "419 SW Porter Dr., Des Moines, IA 50266", "Marketing");
            Console.WriteLine(ClastanelliB);
            Console.WriteLine(); // space
            string michiaJ = setUserInfo("Jim", "Michia");  // utilize default parameter arguments
            Console.WriteLine(michiaJ);
            Console.WriteLine(); // space

            // arguments by ref - not an efficient example - rounds up
            Console.WriteLine("===== using ref argument with decimal =====");
            const decimal TIP_PERCENT = .2m;  // used decimal instead of double so not to use yourNumber.ToString("0.00"); or String.Format("{0:0.00}", 1.4);
            static void calcTip(ref decimal mealPriceCalcTip)
            {
                mealPriceCalcTip = (mealPriceCalcTip * TIP_PERCENT) + mealPriceCalcTip;
            
            }

            Console.Write("USING DECIMAL- Enter meal subtotal to calculate price with 20% tip: ");
            decimal mealPrice = Convert.ToDecimal(Console.ReadLine());
            decimal tipAmount = (mealPrice * TIP_PERCENT);
            Console.WriteLine("Meal Subtotal: " + mealPrice);  // <<-- order is important to display pre method value
            calcTip(ref mealPrice);  // <<-- order is important to dispaly post method value below
            Console.WriteLine("Tip Amount: " + Math.Round(tipAmount, 2));
            Console.WriteLine("with 20% tip: $" + Math.Round(mealPrice, 2));

            //
            Console.WriteLine(); // space
            Console.WriteLine("===== using ref argument with double =====");
            const double TIP_PERCENTb = .2;
            static void calcTipb(ref double mealPriceCalcTip)
            {
                mealPriceCalcTip = (mealPriceCalcTip * TIP_PERCENTb) + mealPriceCalcTip;

            }

            Console.Write("USING DOUBLE- Enter meal subtotal to calculate price with 20% tip: ");
            double mealPriceb = Convert.ToDouble(Console.ReadLine());
            double tipAmountb = (mealPriceb * TIP_PERCENTb);
            Console.WriteLine("Meal Subtotal: " + mealPriceb);  // <<-- order is important to display pre method value
            calcTipb(ref mealPriceb);  // <<-- order is important to dispaly post method value below
            Console.WriteLine("Tip Amount: " + tipAmountb.ToString("0.00"));  // format use yourNumber.ToString("0.00");
            Console.WriteLine("with 20% tip: $" + Math.Round(mealPriceb, 2));

            Console.WriteLine(); // space
            // out argument usage
            // example uses mix data types
            //Italy
            static void getItaly(out string countryName, out string capital, out int population, out double lat, out double lng)
            {
                countryName = "Italy";
                capital = "Rome";
                population = 60665551;
                lat = 42.83333333;
                lng = 12.83333333;
            }


            // France 
            static void getFrance(out string countryName, out string capital, out int population, out double lat, out double lng)
            {
                countryName = "France";
                capital = "Paris";
                population = 66710000;
                lat = 47.824905;
                lng = 2.618787;
            }

            string argCountry;
            string argCapital;
            int argPopulation;
            double argLat;
            double argLng;
            
            getItaly(out argCountry, out argCapital, out argPopulation, out argLat, out argLng);
            Console.WriteLine($"Country: {argCountry}, Capital: {argCapital}, Population: {argPopulation}, Lat/Long: {argLat}/{argLng}");

            Console.WriteLine(); // space
            getFrance(out argCountry, out argCapital, out argPopulation, out argLat, out argLng);
            Console.WriteLine($"Country: {argCountry}, Capital: {argCapital}, Population: {argPopulation}, Lat/Long: {argLat}/{argLng}");


            Console.ReadKey();
        }
    }
}
