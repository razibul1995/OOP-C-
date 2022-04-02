using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example1
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;


        public string GetFullname()
        {
            string fullname = firstName + " " + middleName + " " + lastName;

            return fullname;

        }
    }

    
}
