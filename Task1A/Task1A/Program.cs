using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Caitlin", "Pretorius", 53000, 4, 1234567);
            Console.WriteLine("First name = {0}", person1.Fname);
            Console.WriteLine("Last name = {0}", person1.Lname);
            Console.WriteLine("Pay Rate = ${0}", person1.Payrate);
            Console.WriteLine("Tax = {0}%", person1.Tax);
            Console.WriteLine("Account Number = {0}", person1.Account);
        }
    }
    class Person
    {
        string fname;
        string lname;
        int payrate;
        int tax;
        int account;

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        public int Payrate
        {
            get
            {
                return payrate;
            }
            set
            {
                payrate = value;
            }
        }
        public int Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }
            public int Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }

        public Person(string _fname, string _lname, int _payrate, int _tax, int _account)
        {
            Fname = _fname;
            Lname = _lname;
            Payrate = _payrate;
            Tax = _tax;
            Account = _account;
        }

    }
}
