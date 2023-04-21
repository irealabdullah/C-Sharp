//----------------------------
// Types of Inheritence In C#
//----------------------------

/*  1. Single 
    2. Hierarchical
    3. Multi Level
    4. Multiple(Using Interface)
*/

//--------------------
// Single Inheritence
//--------------------

// Parent <--- Child

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfInheritence
{
    class parent
    {
        public void Base()
        {
            Console.WriteLine("This is a parent class");
        }

    }

    class child : parent
    {
        public void derived()

        {
            Console.WriteLine("This is a Child Class");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            parent P = new parent();
            P.Base();
            child c = new child();
            c.Base();
            c.derived();
            Console.ReadLine();
            
        }

    }
}

//-------------------------
// Hierarchical Inheritence
//-------------------------


//        |---> child 1
// parent |---> child 2
//        |---> child 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace TypesOfInheritence
{
    class parent
    {
        public void Base()
        {
            Console.WriteLine("This is a parent class");
        }

    }

    class child : parent
    {
        public void derived()

        {
            Console.WriteLine("This is a Child Class 1");
        }
    }

    class child2 : parent
    {
        public void derived1()
        {
            Console.WriteLine("This is a Child Class 2");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            parent P = new parent();
            P.Base();
            child c = new child();
            c.Base();
            child2 c2 = new child2();
            c2.Base();
            
           
            Console.ReadLine();
            
        }

    }
}

*/

//------------------------
// Multi Level Inheritence
//------------------------

//Class A (Grandfather) --> Class B (Father) --> Class C (Child)
//Class C class A ka data/methods bhi access kar sakti hai 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfInheritence
{
    class Grandfather
    {
        public void SuperClass()
        {
            Console.WriteLine("This is a GrandFather class");
        }

    }

    class Father : Grandfather
    {
        public void IntermediateClass()

        {
            Console.WriteLine("This is a Father Class");
        }
    }

    class Child : Father
    {
        public void DerivedClass()
        {
            Console.WriteLine("This is a Child Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Grandfather G = new Grandfather();  // ismain aik he ayee ga
            G.SuperClass();

            Father F = new Father(); // ismain donoo ayee ga
            F.SuperClass();

            Child c = new Child();  // ismain teeno ayee ga
            c.SuperClass();
           
            Console.ReadLine();
            
        }

    }
}

// we will study 4th type later in abstraction topic
// we can also create class separately by right click and choose class