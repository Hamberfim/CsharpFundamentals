/***************************************************************
* Name        : baseOverloaded
* Author      : Anthony Hamlin
* Created     : 03/04/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : Work based on needed
*               specifications or project scope
* Description : using constructor methods vs setter/getter methods        
***************************************************************/
using System;

namespace baseOverloaded
{
    class Program
    {
        // base class
        public class Employee
        {
            private string fname, lname, department, title, email;
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
            public Employee(string fname, string lname, string department, string title, double salary, string email)
            {
                Console.WriteLine($"{fname} {lname}, {department}, {title}, {salary:C}, {email}");
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

            public void setEmail(string email)
            {
                this.email = email;
            }

            // set all values
            public void setAllValues(string fname, string lname, string department, string title, double salary, string email)
            {
                this.fname = fname;
                this.lname = lname;
                this.department = department;
                this.title = title;
                this.salary = salary;
                this.email = email;
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

            public string getEmail()
            {
                return email;
            }

            //get All
            public string getAllValues()
            {
                return $"{fname} {lname}, {department}, {title}, {salary:c}, {email}";
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Using Overloaded Constructors =====");
            Employee justObject = new Employee();
            Employee billWilliamName = new Employee("bill", "William");
            Employee billWilliamDept = new Employee("bill", "William", "accounting");
            Employee billWilliamTitle = new Employee("bill", "William", "accounting", "manager");
            Employee billWilliamSalary = new Employee("bill", "William", "accounting", "manager", 74000.00, "williamb@fake.org");

            Console.WriteLine();

            Console.WriteLine("===== Using Setters/Getters =====");
            Employee lindaGarcia = new Employee();
            lindaGarcia.setfName("Linda");
            lindaGarcia.setlName("Garcia");
            Console.WriteLine($"{lindaGarcia.getfName()} {lindaGarcia.getlName()}");

            lindaGarcia.setAllValues("linda", "garcia", "human resources", "director", 62500.00, "garcial@fake.org");
            Console.WriteLine(lindaGarcia.getAllValues());

            Console.WriteLine("\n\n");
        }
    }
}
