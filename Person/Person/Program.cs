using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 employee1 = new Person1("Jacob", "Er");
            employee1.Fname = "Jacob";
            Console.WriteLine(employee1.Fname);
            Console.WriteLine(employee1.Lname);
        }
    }
}
