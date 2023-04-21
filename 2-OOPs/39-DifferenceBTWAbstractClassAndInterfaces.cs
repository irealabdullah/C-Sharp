//-----------------------------------------------------
//  DIFFERENCE BETWEEN ABSTRACT CLASS AND INTERFACE
//-----------------------------------------------------

/*
-------------------------------------------------------------------------------------------
1. Abstract class aik class ko inherit kar sakti hai aur --  aik se zaida interfaces se inherit hoo sakti hai 
--------------------------------------------------------------------------------------------------
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
    interface i1
    {
    }

    interface i2
    {
    }

    abstract class Human : student, i1,i2 //aik abstract class ko doo classes se inherit nahi karwa sakte
    {
    }

    abstract class Person 
    {
    }

    class student : Person
    { 
    }

    class teacher : Person
    { 
    }

    class program
    {
        static void Main(string[] args)
        {     
        }
    }
}

//-------------------------------------------------------------------
//1. Interface main we cannot inherit class but can inherit interfaces
//-------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    interface i1 : i2
    {

    }

    interface i2 // : student // error --> interface will not inherit from class either it is abstract or normal class
    {

    }
    abstract class Person
    {

    }

    class student : i1 ,i2 //class can inherit from interface
    {
    
    }
    class program
    {
        static void Main(string[] args)
        {

        }

    }
}

//-------------------------------------------------------------------------------------
//-----------------------------------COMPLETED-----------------------------------------
//-------------------------------------------------------------------------------------


//---------------------------------------------------
// 2. An abstract class can have methods with a body.	
//---------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    abstract class Person
    {
        abstract public void display();

        public void show()
        {

        }
    }

    class program
    {
        static void Main(string[] args)
        {

        }
    }
}

//-------------------------------------------------
// 2. An interface cannot have methods with a body.
//-------------------------------------------------

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

    class program
    {
        static void Main(string[] args)
        {

        }

    }
}

*/

//-------------------------------------------------------------------------------------
//-----------------------------------COMPLETED-----------------------------------------
//-------------------------------------------------------------------------------------



//------------------------------------------------------------------------
// 3. An abstract class method is implemented using the override keyword.
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    
    abstract class Person
    {
        abstract public void display();
        
        public void show()
        {

        }
    }

    class student : Person
    {
        public override void display() // see we used override keyword
        {
            
        }
        
    }

    class program
    {
        static void Main(string[] args)
        {

        }

    }
}

*/

//-------------------------------------------------
// 3. An interface method is implemented without using the override keyword.
//-------------------------------------------------

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
        public abstract void showDetails();

    }

    interface i1
    {
        void show();
    }

    class student : person , i1
    {
        public override void showDetails()   // override ka keyword use kia hai when we inherit from abstract class
        {
            Console.WriteLine("This is a Abstract Class Method");
        }

        public void show()  // override ka keyword use nahi kia when inheriting interface
        {
            Console.WriteLine("This is a interface Method");

        }
    }

    class program
    {
        static void Main(string[] args)
        {

        }

    }
}


//-------------------------------------------------------------------------------------
//-----------------------------------COMPLETED-----------------------------------------
//-------------------------------------------------------------------------------------

//-----------------------------------------------------------------------------------------------------
// 4. An abstract class is a better option when you need to implement common methods and declare common abstract methods.
// abstract class hum tab use karte hain jab hum chah rahe hoon ke child class ke jitne bhi properties common hain
// woh sare abstract class main declare kardain 
//-----------------------------------------------------------------------------------

//-----------------------------------------------------------------------------------
// 4.An interface is a better option when you need to declare only abstract methods.
// we use interface jab hamain 100% abstract method banane hooon bus 
//-----------------------------------------------------------------------------------

//-------------------------------------------------------------------------------------
//-----------------------------------COMPLETED-----------------------------------------
//-------------------------------------------------------------------------------------

//-------------------------------------------------------------------------------------
//5. An abstract class can declare constructors and destructors.
//-------------------------------------------------------------------------------------

//-------------------------------------------------------------------------------------
//5. An interface cannot declare constructors or destructors.
//-------------------------------------------------------------------------------------

//-------------------------------------------------------------------------------------
//-----------------------------------COMPLETED-----------------------------------------
//-------------------------------------------------------------------------------------

//--------------------------------------------------------------------------------------------------
//6. If you want to declare an abstract member in abstract class then abstract keyword is mandatory.
//--------------------------------------------------------------------------------------------------

//-----------------------------------------------------------------------------------------------------
//6. If you want to declare an abstract member in interface then abstract keyword is not mandatory because members of interface are abstract by default.
//-----------------------------------------------------------------------------------------------------

