/***************************************************************
* Name        : baseOverloaded
* Author      : Anthony Hamlin
* Created     : 03/04/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : using constructor methods vds setter/getter methods        
***************************************************************/
using System;

namespace baseOverloaded
{
    class Program
    {
        // base class
        public class Employee
        {
            private string fname, lname, department, title;
            private double salary;

            // default constructor
            public Employee()
            {
                Console.WriteLine($"An Employee Object has been Created\n");
            }

            // basic constructor 
            public Employee(string fname, string lname)
            {
                Console.WriteLine($"{fname} {lname}");
            }

            // overloaded constructor
            public Employee(string fname, string lname, string department)
            {
                Console.WriteLine($"{fname} {lname}, {department}");
            }

            // overloaded constructor
            public Employee(string fname, string lname, string department, string title)
            {
                Console.WriteLine($"{fname} {lname}, {department}, {title}");
            }

            // overloaded constructor
            public Employee(string fname, string lname, string department, string title, double salary)
            {
                Console.WriteLine($"{fname} {lname}, {department}, {title}, {salary:C}");
            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // setters
            public void setfName(string fname)
            {
                this.fname = fname;
            }

            public void setlName(string lname)
            {
                this.lname = lname;
            }

            public void setDept(string department)
            {
                this.department = department;
            }

            public void setTitle(string title)
            {
                this.title = title;
            }

            public void setSalary(double salary)
            {
                this.salary = salary;
            }

            // set all values
            public void setAllValues(string fname, string lname, string department, string title, double salary)
            {
                this.fname = fname;
                this.lname = lname;
                this.department = department;
                this.title = title;
                this.salary = salary;
            }

            // getters
            public string getfName()
            {
                return fname;
            }
            public string getlName()
            {
                return lname;
            }

            public string getDept()
            {
                return department;
            }

            public string getTitle()
            {
                return title;
            }

            public double getSalary()
            {
                return salary;
            }

            //get All
            public string getAllValues()
            {
                return $"{fname} {lname}, {department}, {title}, {salary:c}";
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("===== Using Overloaded Constructors =====");
            Employee justObject = new Employee();
            Employee billWilliamName = new Employee("bill", "William");
            Employee billWilliamDept = new Employee("bill", "William", "accounting");
            Employee billWilliamTitle = new Employee("bill", "William", "accounting", "manager");
            Employee billWilliamSalary = new Employee("bill", "William", "accounting", "manager", 74000.00);

            Console.WriteLine();

            Console.WriteLine("===== Using Setters/Getters =====");
            Employee lindaGarcia = new Employee();
            lindaGarcia.setfName("Linda");
            lindaGarcia.setlName("Garcia");
            Console.WriteLine($"{lindaGarcia.getfName()} {lindaGarcia.getlName()}");

            lindaGarcia.setAllValues("linda", "garcia", "human resource", "director", 62500.00);
            Console.WriteLine(lindaGarcia.getAllValues());

            Console.WriteLine("\n\n");
        }
    }
}
