//----------------------
//  Explicit INTERFACES 
//----------------------

/*
 1. Explicit interface concept yeh hai ke 2 interface hain and aur un dono main same name ka method bana hai Exp void show();
    ab jab aik child class in dono ko inherit karwaye ge to compiler will get confuse which void show() to call 
    isi wajah se we use Explicit Interface concept
 2. Types of Interfaces 
    1#IMPLICIT Interface Implementation
    2#EXPLICIT Interface Implementation
 3. we do explicit implementation jab methods ka name same hoon dono interfaces main
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    interface I1
    {
        void show();
    }
    interface I2
    {
        void show()
    }
    class child: I1,I2
    {
        public void show() // kaise pata chale ga ke yeh interface 1 se hai ya interface 2 se hai --> we have ambiguty
        {
            Console.WriteLine("Hello World");
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
}

//----------------------------------------
// Ways to call in explicitly implementation
//----------------------------------------

// We use shortcut to define body explitly

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    interface I1
    {
        void show();
    }
    interface I2
    {
        void show();
    }
    class child: I1,I2
    {
        void I1.show()
        {
            Console.WriteLine("Hello world i1");
        }

        void I2.show()
        {
            Console.WriteLine("Tera baap i2");
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            //Method 1
            child obj = new child();
            ((I1)obj).show();
            ((I2)obj).show(); //That is how we call object in explicit call

            //class ka refrence variable hai isko convert kia jaa raha hai i1 ke refrence variable main

            //Method 2
            I1 obj1 = new child();
            obj1.show();

            I2 obj2 = new child();
            obj2.show();

            Console.ReadLine();
        }

    }
}

//------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    interface I1
    {
        void show();
    }
    interface I2
    {
        void show();
    }
    class child : I1, I2  // In a class we can define one as Implicit and other as Explicit
    {
        public void show()
        {
            Console.WriteLine("This is Implicit I1");
        }
        void I2.show()
        {
            Console.WriteLine("This is Explicit I2");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            
            child obj = new child();
            
            obj.show(); // In Implicit we can directly make object 

            ((I1)obj).show();
            ((I2)obj).show(); //In explicit we do typecasting 

            Console.ReadLine();
        }

    }
}
