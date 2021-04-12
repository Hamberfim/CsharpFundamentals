using System;

namespace switchAgainAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeLevel = "";
            decimal employeeSalary = 0.0m;
            string employeeTitle = "";

            Console.Write("Enter the potential employee name: ");
            string employeeName = Console.ReadLine();

            Console.Write("\nEnter the employment level (Jr=100, Associate=200, Lead=300, Engineer=400, Senior=500 or All others=empty): ");
            employeeLevel = Console.ReadLine();

            switch (employeeLevel)
            {
                case "500":
                    employeeTitle = "Senior Software Engineer";
                    employeeSalary = 84000.0m;
                    break;
                case "400":
                    employeeTitle = "Software Engineer";
                    employeeSalary = 77000.0m;
                    break;
                case "300":
                    employeeTitle = "Lead Software Associate";
                    employeeSalary = 70000.0m;
                    break;
                case "200":
                    employeeTitle = "Software Associate";
                    employeeSalary = 63000.0m;
                    break;
                case "100":
                    employeeTitle = "Junior Software Associate";
                    employeeSalary = 56000.0m;
                    break;
                default:
                    employeeTitle = "Intern Software Associate";
                    employeeSalary = 21000.0m;
                    break;
            }

            Console.WriteLine($"\nIf hired {employeeName} would be a {employeeTitle} and would start making about {employeeSalary:C2} a year.");
            Console.WriteLine();


            string sku = "01-MN-L";
            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch(product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch(product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }
            Console.WriteLine($"Product: {size} {color} {type}");

            Console.WriteLine("\n\n");
        }
    }
}
