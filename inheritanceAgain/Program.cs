using System;

namespace inheritanceAgain
{
    class Program
    {
        // pizza base class
        public class Pizza
        {
            private string name;
            private string crust;
            private string sauce;
            private string toppings;
            private string size;
            private int qty;

            // constructor
            public Pizza()
            {
                name = "basic cheese pizza";
                crust = "thin";
                sauce = "tomato";
                toppings = "cheese";
                size = "small";
                qty = 1;
            }

            // setters/getters
            public void setValues(string name, string crust, string sauce, string toppings, string size, int qty)
            {
                this.name = name;
                this.crust = crust;
                this.sauce = sauce;
                this.toppings = toppings;
                this.size = size;
                this.qty = qty;
            }

            public string getName()
            {
                return name;
            }

            public string getCrust()
            {
                return crust;
            }

            public string getSauce()
            {
                return sauce;
            }

            public string getToppings()
            {
                return toppings;
            }

            public string getSize()
            {
                return size;
            }

            public int getQty()
            {
                return qty;
            }


        }


        static void Main(string[] args)
        {
            // instance of base class constructor
            Pizza thinCheese = new Pizza();
            Console.WriteLine($"You ordered a {thinCheese.getName()}\nCrust: {thinCheese.getCrust()}\nSauce: {thinCheese.getSauce()}\n" +
                $"Toppings: {thinCheese.getToppings()}\nSize: {thinCheese.getSize()}\nQuantity: {thinCheese.getQty()}");

            Console.WriteLine();

            // over-ride constructor defaults
            Pizza loadedPizza = new Pizza();

            loadedPizza.setValues("Loaded pizza", "pan", "tomato", "pepperoni, italian sausage, italian peppers, green olives, red onion, buffalo mozzarella", "large", 2);

            Console.WriteLine($"You ordered a {loadedPizza.getName()}:\nCrust: {loadedPizza.getCrust()}\nSauce: {loadedPizza.getSauce()}\n" +
                $"Toppings: {loadedPizza.getToppings()}\nSize: {loadedPizza.getSize()}\nQuantity: {loadedPizza.getQty()}");

            Console.WriteLine();

            // over-ride constructor defaults
            Pizza neoPizza = new Pizza();

            neoPizza.setValues("Neapolitan pizza", "hamd-tossed", "tomato and olive oil", "basil and buffalo mozzarella", "mediume", 3);

            Console.WriteLine($"You ordered a {neoPizza.getName()}:\nCrust: {neoPizza.getCrust()}\nSauce: {neoPizza.getSauce()}\n" +
                $"Toppings: {neoPizza.getToppings()}\nSize: {neoPizza.getSize()}\nQuantity: {neoPizza.getQty()}");

            Console.WriteLine("\n\n\n");
        }
    }
}
