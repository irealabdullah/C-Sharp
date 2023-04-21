//-----------------------------------------------------
//  SIMILARITIES BETWEEN ABSTRACT CLASS AND INTERFACE
//-----------------------------------------------------

/*
Abstract class and Interfaces both declare methods without body 
-- but in abstract class we can declare abstract method or we cannot declare abstract method 
-- but in interface sab methods abstract he hoote hain and there are no variable
    
Abstract --> 0-100% Abstract
Interfaces --> 100% Abstract
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
    interface Interface1
    {
        void show(); // By default abstract bhi hai aur public bhi hai 
    }

    abstract class person
    {
        public abstract void display(); // Here we have to tell that it is abstract or not so we use abstract keyword and also public keyword
    }

    class program
    {
        static void Main(string[] args)
        { 
        }
    }
}

//----------------------------------------
// 2. abstract method aur interface -- in dono ko body kon dega --> sirf uski child class
//----------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    abstract class person
    {
        public abstract void display();
    }
    interface Interface1
    {
        void show(); 
    }

    class Child : person , Interface1 // abstract pehle phir interface likhte hain
    {
        public override void display()
        {
            Console.WriteLine("ABSTRACT CLASS METHOD");
        }
        public void show()
        {
            Console.WriteLine("INTERFACE METHOD");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.show();
            obj.display();

            Console.ReadLine();
        }
    }
}

//-------------------------------------------------------------------------
// 3. Both abstract class and interface can inherit multiple interfaces
//    means abstract class aik se zaida interface ko inherit kar sakta hai aur 
//    interface bhi aik se zaida interface ko inherit kar sakta hai
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    interface i1
    {
    }

    interface i2
    {
    }

    interface i3 : i1, i2
    {
    }
    
    abstract class person : i1, i2, i3
    {
    }

    class program
    {
        static void Main(string[] args)
        {
        }
    }
}

//---------------------------------------------------------------------
// 4. Both abstract class and interface ka object nahi bana
// sakte hum loog but refrence variable hum dono ka bana sakte hain
//---------------------------------------------------------------------