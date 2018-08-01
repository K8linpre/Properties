using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person1
    {
        string fname;
        string lname;

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

        public Person1(string _fname, string _lname)
        {
            Fname = _fname;
            Lname = _lname;
        } 
   
    }
}

