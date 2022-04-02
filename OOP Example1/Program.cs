using System;

namespace OOP_Example1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.firstName = "Md.";
            p1.middleName = "Razibul";
            p1.lastName = "Hasan";

            string fullname = p1.GetFullname();
            Console.WriteLine(fullname);
            Console.ReadKey();
        }
    }
}
