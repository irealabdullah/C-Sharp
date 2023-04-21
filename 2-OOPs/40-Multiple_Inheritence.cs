//----------------------
// Multiple Inheritence
//----------------------

/*
 1. Multiple inheritence using classes is not supported in C# . A child cannot have two father
 2. we do Multiple inheritence  BY -->  Multiple inheritence using interface 
                          \
 3. Class parent1----------\ 
                            \  SubClass Child
    Interface parent--------/ 
                           /
                          /
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
    class parent1
    {
        public void show()
        {
            Console.WriteLine("This is a class parent 1");
        }
    }

    interface parent2
    {
        void show();
    }
    
    class child:parent1,parent2
    {
        public void show2()
        {
            Console.WriteLine("This is parent 2 interface");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            child obj =new child();
            obj.show();
            obj.show2();
            Console.ReadLine();
        }

    }
}

//If method name is same in interface and class how will child class call these methods?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class parent1
    {
        public void show()
        {
            Console.WriteLine("This is a class parent 1");
        }
    }

    interface parent2
    {
        void show();
    }
    
    class child:parent1,parent2
    {
        void parent2.show()
        {
            Console.WriteLine("I will call this method Explicitly (interface parent 2)");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            child obj =new child();
            obj.show();

            parent2 Obj1 = new child(); //interface ka object tu bana nahi sakte so we use this method
            Obj1.show(); // we put child object in parent refrence 

            Console.ReadLine();
        }
    }
}


