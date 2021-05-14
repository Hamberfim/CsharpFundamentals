using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseClass
{
    public class Person
    {
        // constructor - redundant
        public Person()
        {
            // default construct is automatic
        }

        // getters/setters
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }

        // a field rather than a property
        string _middleName = "Judas";

        // method - concatinate fName, lName and age.
        public string GetPersonInfo()
        {
            return FName + " " + LName + ", age:" + Age.ToString();
        }

        // property to mimic part of the method
        public string FullName
        {
            get
            {
                return FName + " " + _middleName + " " + LName;
            }
        }

    }
}
