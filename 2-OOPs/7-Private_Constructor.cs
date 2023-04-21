//-----------------------------
//Concept of private constructor
//-----------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class parent
    {
        private parent()
        {

        }
    }
    class child : parent() // Error here: cannot access class because constuctor is private in parent class
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
          parent p = new parent(); //error because it is inaccesible 
        }
    }
}


//------------------------------------
// Why we make private constructor?
//------------------------------------

// 1. we make private constructor when we want to restrict (that no object is made for that class)
// 2. we dont want to inherit from base/parent class
// 3. Restriction laga de hum loogoon ne isliye hum private constructor ka use karte hain 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class parent
    {
        private parent()
        {

        }

        public static void gettime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            parent.gettime();
            Console.ReadLine();
        }
    }
}

// private constructor ke sath hum loog Default constructor nahi bana sakte 

class parent
    {
        private parent() //private constructor
        { 

        }

        public parent() //default constructor
        {
            
        }
    }

// private constructor parameterized hoo sakta hain magar it is of no use 