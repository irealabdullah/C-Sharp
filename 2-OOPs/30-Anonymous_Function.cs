//-----------------------------------
//	ANONYMOUS FUNCTION/METHODS IN C#
//-----------------------------------

/*
1. ANONYMOUS means jiska koi name nah hoo
2. we use ANONYMOUS functions with delegates only
3. Delegate ke objects main hum kisi method ka refrence store karte hain as we know
4. ANONYMOUS method is a method without name just the body
5. ANONYMOUS method can be defined using "DELEGATE" keyword
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
   public delegate void MyDelegate(int a);

   class Program
   {
       public static void mymethod(int a)
       {
           a += 10;
           Console.WriteLine("Answer is {0} ",a);
       }

       static void Main(string[] args)
       {
           MyDelegate obj = new MyDelegate(Program.mymethod);
           obj.Invoke(10);
           //obj(10);
           Console.ReadLine();
       }

   }
}

//---------------------------------------------
//ANONYMOUS FUNCTION Concept:
//---------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    public delegate void MyDelegate(int a); // IF WE USE INT HERE WE WILL USE RETURN STATEMENT IN ANONYMOUS
    // METHOD AND PRINT IN MAIN METHOD Console.ReadLine("obj.Invoke(10)");
                                    
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate obj = delegate (int a) // ANONYMOUS FUNCTION/METHOD
            {
                a += 10;
                Console.WriteLine("Answer is {0} ", a);
            };
            obj.Invoke(10);
            //obj(10);
            Console.ReadLine();
        }
    }
}

// we dont use access modifiers with anonymous function
// we use return type as delegate type 

/*
Advantages of Anonymous Function:
1. Lesser typing work because we don’t required to write access modifier, return type and name of the function.
2. Anonymous functions are suggested when code volumes are less.

Limitations of Anonymous Function:
1. It cannot contain jump statement like goto, break or continue.
2. It cannot access ref or out parameter of an outer method.

Points To Remember:
1. Anonymous method can be defined using the delegate keyword
2. Anonymous method must be assigned to a delegate.
3. Anonymous method can access outer variables or functions.
4. Anonymous method can be passed as a parameter. --> see below code
5. Anonymous method can be used as event handlers. 
*/


//---------------------------------------------
//Anonymous method can be passed as a parameter
//---------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    public delegate void MyDelegate(int num);
     
    class Program
    {
        public static void mymethod(MyDelegate obj1, int num)
        {
            num += 10;
            obj1.Invoke(num);
        }
        static void Main(string[] args)
        {
            Program.mymethod(delegate (int b) {b += 10;Console.WriteLine(b);}, 5);
            Console.ReadLine();
        }
    }
}




