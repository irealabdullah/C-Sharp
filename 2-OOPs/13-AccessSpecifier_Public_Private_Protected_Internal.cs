//--------------------------------
// Concept of Access Modfiers in C# 
//--------------------------------
/* 
In C#, there are four commonly used access modifiers/specifiers
1. public 
2. private 
3. protected 
4. Internal

Note# if there is no access specifier mentioned then it is by default ---------> PRIVATE
 */
//---------------------------------
//  Concept of Public
//---------------------------------
/* 
 1. Public modifier can be Used in Whole Application --> main method
 2. Public modifier can be used current class
 3. Public modifier can be used in derived class --> used in child class
 
 4. Public modifier can be applicable to outside the namespace/ assembly --> access class in other namespaces
 we make two namespace in one solution 
 then we add refrence by 
 RightClick>ADD>REFRENCE>PROJECT ---> ADD IT 
 Then we add ---> using accessspecifier1;

 5.APPLICABLE TO  OUTSIDE THE NAMESPACE BUT IN DERIVED CLASS
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AcessSpecifier
{

    public class parent
    {
        public void show()  //It can be access because of public
        {
            Console.WriteLine("This is a public method...");
        }

        public void show1()
        {
            parent p = new parent();
            p.show();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.show1();
            Console.ReadLine();
        }

    }
}

//------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AcessSpecifier1
{

    public class parent
    {
        public void show()  //It can be access because of private
        {
            Console.WriteLine("This is a public method...");
        }

        public void show1()
        {
            parent p = new parent();
            p.show();

        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.show1();
            Console.ReadLine();
        }

    }
} 

///////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessSpecifier1; // add this

namespace AccessSpecifier2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.show1();
            Console.ReadLine(); 
        }
    }
}


//access specifier2 chalane ke liye 
// right click on solution explorer --> properties --> change to accessSpecifier2
//-----------------------------------------------------------------------



/*
-------------------------------------------
PRIVATE 
-------------------------------------------

------------------------------------------------------------------
APPLICABLE TO THE APPLICATION ----> NO
------------------------------------------------------------------
APPLICABLE TO THE CURRENT CLASS ---> YES
------------------------------------------------------------------
APPLICABLE TO THE DERIVED CLASS ---> NO
------------------------------------------------------------------
APPLICABLE TO  OUTSIDE THE NAMESPACE / ASSEMBLY ---> NO
------------------------------------------------------------------
APPLICABLE TO  OUTSIDE THE NAMESPACE BUT IN DERIVED CLASS ---> NO
------------------------------------------------------------------

*/


/*
-------------------------------------------
PROTECTED
-------------------------------------------

------------------------------------------------------------------
APPLICABLE TO THE APPLICATION ----> NO
------------------------------------------------------------------
APPLICABLE TO THE CURRENT CLASS ---> YES
------------------------------------------------------------------
APPLICABLE TO THE DERIVED CLASS ---> YES
------------------------------------------------------------------
APPLICABLE TO  OUTSIDE THE NAMESPACE / ASSEMBLY ---> NO
------------------------------------------------------------------
APPLICABLE TO  OUTSIDE THE NAMESPACE BUT IN DERIVED CLASS ---> YES
------------------------------------------------------------------

*/

/*
-------------------------------------------
INTERNAL
-------------------------------------------
internal member dosre namespace main use nahi hoo sakta bus yahi yaad rakho 


------------------------------------------------------------------
APPLICABLE TO THE APPLICATION ----> YES
------------------------------------------------------------------
APPLICABLE TO THE CURRENT CLASS ---> YES
------------------------------------------------------------------
APPLICABLE TO THE DERIVED CLASS ---> YES
------------------------------------------------------------------
APPLICABLE TO  OUTSIDE THE NAMESPACE / ASSEMBLY ---> NO
------------------------------------------------------------------
APPLICABLE TO  OUTSIDE THE NAMESPACE BUT IN DERIVED CLASS ---> NO
------------------------------------------------------------------

*/

/*
1. aik baat yaad rakhna yeh ke hum loog ussi class main use kar sakte hain 
APPLICABLE TO THE CURRENT CLASS ---> YES -->For all private protected public and internal
*/

//-----------------------------------------------

/*
2. important point: class ke sath public aur internal ke keyword he use ho sakte hain 
if we use word public with class it can be access in other namespaces
and if we dont use public keyword it is by default internal class and it cannot 
be accessed in other namespace  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AcessSpecifier1
{

    public class parent  // Agar hum loog yahan public use nah karain tu ByDefault class INTERNAL hooo ge 
    {
        public void show()  
        {
            Console.WriteLine("This is a public method...");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.show();
            Console.ReadLine(); 
        }

    }
}
 

/*INTERNAL: The internal access modifier allows the class members to be accessible only within the classes of the same namespace / assembly. 
An assembly is a file that is automatically generated by the compiler upon successful compilation of a .NET application. 
The code declares a variable called NumOne as internal, which means it has only assembly-level access. 
*/