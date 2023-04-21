//-----------------------------
// 3. Method hiding IN INHERITANCE
//-----------------------------

//we make method with same name and use inheritance concept  

/*
    1. This concept of Method hiding is used in Dynamic Polymorphysim
    2. We use “new” keyword in derived function name to show that implementation of the function in derived class is intentional and derived class no longer want to use base class method.
    3. NOTE: If we do not use “new” keyword then compiler will raise only warning, but, program will work fine.
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
    class parent
    {
        public void show()  //see this and below method in child class are same
        {
            Console.WriteLine("This is a Parent Class");
        }
    }

    class child: parent
    {
        public new void show() // here we use new keyword so that we tell our compiler that hum ne jaan booch kar hide nahi kia 
        {
            Console.WriteLine("This is a child class");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            child c = new child(); // yahan par child class ka method parent class ke method ko hide kar raha hai 
            c.show();
          
            Console.ReadLine();
        }

    }
}


/*Different Ways To Call A Hidden Base Class Member From Derived Class 
1.	Use base keyword
2.	Cast child type to parent type and invoke the hidden member.
3.	ParentClass PC = new ChildClass();  --> Parent class can have the reference of its child class.
PC.hiddenMethod();	

Important Point: When we create the object of child class, parent class object is also created.
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
    class parent
    {
        public void show()
        {
            Console.WriteLine("This is a Parent Class");
        }
    }

    class child: parent
    {
        public new void show() 
        {
            
           // base.show(); //method 1
            Console.WriteLine("This is a child class");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            // parent p = child();  //method 3
            // p.show();

            //((parent)c).show(); //method 2
            c.show();
          
            Console.ReadLine();
        }

    }
}
