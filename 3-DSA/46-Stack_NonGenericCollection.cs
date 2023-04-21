//----------
//  Stack 
//----------

/*
1. store hetro and homo elements
2. we can store any type of data (not type safe)
3. resize dynamically at runtime 
4. Stack means pile of object (Dher Lagana)
5. Push --> Insert Element ||| Pop --> Take out Element   LIFO (Last in - First out)
6. Stack allows null values and duplicate values
7. Stack is in generic and non-Generic stack 
8. Stack provides push() to insert, pop() or peek() to retrieve values 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
            Stack Mystack = new Stack();

            Mystack.Push(1123);
            Mystack.Push("Abdullah");
            Mystack.Push(5.11);
            Mystack.Push(25);
            Mystack.Push("Microsoft"); //LIFO 

            foreach (object item in Mystack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();           
        }
    }
}

//--------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
            Stack Mystack = new Stack();

            Mystack.Push("Abdullah");
            Mystack.Push(null);  //used null 
            Mystack.Push("Abdullah"); // null values
            Mystack.Push(1123);

            Console.WriteLine(Mystack.Count); // Count elements
           
            Console.WriteLine(Mystack.Peek()); // retrieve top element in stack 
           
            foreach (object item in Mystack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();           
        }
    }
}

// Stack implements the IEnumerable ,ICollection and ICloneable interfaces
// when inserting element we use push, when removing element we use pop

//-----------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
            Stack Mystack = new Stack();

            Mystack.Push("Abdullah");
            Mystack.Push(null); 
            Mystack.Push(1123);
            Mystack.Push("Abdullah"); 

            string name = Mystack.Peek().ToString(); // storing in name variable 
            Console.WriteLine(name); 
            Console.ReadLine();  
        }
    }
}

//-------------------------------------------------------------
//pop --> not only remove top item but also retrieve that item 
//-------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
            Stack Mystack = new Stack();

            Mystack.Push("Abdullah");
            Mystack.Push("Ali"); 
            Mystack.Push(1123);
            
            foreach (object item in Mystack)
            {
                Console.WriteLine(item);
            }

            Mystack.Pop();

            Console.WriteLine("------------------");

            foreach (object item in Mystack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

//-----------------------------------------------
//Contains ---> Whether item exist in stack or not
//-----------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
            Stack Mystack = new Stack();

            Mystack.Push("Abdullah");
            Mystack.Push("Ali"); 
            Mystack.Push(1123);

            Console.WriteLine(Mystack.Contains("Abdullah")); // if String matches from above it will return bool value TRUE
            Console.ReadLine();  
        }
    }
}

/*
Important Properties And Methods Of Stack

Count	   Returns the total count of elements in the Stack.
Push	   Inserts an item at the top of the stack.
Peek	   Returns the top item from the stack.
Pop		   Removes and returns items from the top of the stack.
Contains   Checks whether an item exists in the stack or not.
Clear	   Removes all items from the stack.
*/
