//-------------------------
// INTERFACES Inheritence
//------------------------

/*
1. Interface can inherit from another interface
2. Parent interface ka refrence variable main we can put child class object EXP: I3 OBJ2 = new CHILD();
3. jo class inherit kare ge woh sabki implementation dege
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
        void print();
    }

    interface I2 
    {
        void print1();
    }

    interface I3: I1, I2   // AB JAB HUM LOOG I3 KO INHERIT KARWAYE GE KISI CLASS SE WE HAVE TO GIVE BODY OF I2 AND I1 ALSO 
    {
        void print2();
    }

    class CHILD : I3 // DEKHA BODY DENI PARHTI HAI 
    {
        public void print()
        {
            Console.WriteLine("Hello World");
        }

        public void print1()
        {
            Console.WriteLine("Hello World");
        }

        public void print2()
        {
            Console.WriteLine("Hello World");
        }
    }
   
    class program
    {
        static void Main(string[] args)
        {
            CHILD obj1 = new CHILD();
            obj1.print();
            obj1.print1();
            obj1.print2();
         
            // I3 OBJ2 = new CHILD();
            // OBJ2.print();
            // OBJ2.print1();
            // OBJ2.print2();
            Console.ReadLine();   
        }
    }
}

