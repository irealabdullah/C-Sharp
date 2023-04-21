
// ----------------
// Lamda Expression
// ----------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Myproject
{
    public delegate void myDelegate(int num);

    class Program
    {
        
        static void Main(string[] args)
        {
            myDelegate obj = delegate (int a)
            {
                a += 5;
                Console.WriteLine(a);

            };

            obj.Invoke(5);
            Console.ReadLine();
        }

    }
}

// ----------------------------
// Concept of Lamda Expression
// ----------------------------

/*
1. Lamda expression is shorthand of Anonymous Function
2. Lamda Operator => used in Lamda Expression
3. Linq to sql main lamda expression use hoota hai 
4. Lamda left side is input/parameter (a)
5. Lamda right side is "Statements" and it can be "Expressions"

6. Lamda expression is of two types:
    1.Statement Lamda  --->       input => {Statements};
    2.Expression Lamda --->       input => expression; 

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
    public delegate void myDelegate(int num);
    
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate obj = (a)=>  //lamda expression
            {
                a += 5;
                Console.WriteLine(a);
            };

            obj.Invoke(5);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    public delegate int myDelegate(int num);

    class Program
    {

        static void Main(string[] args)
        {
            myDelegate obj = (a) => a * a;  //obj ko return hoo rahi hai
            myDelegate obj1 = (a) => a * a * a;

            Console.WriteLine("Square of Five is {0}",obj.Invoke(5));
            Console.WriteLine("Cube of Five is {0}", obj1.Invoke(5));

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    public delegate int myDelegate(int num,int num2);
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate obj = (a,b) => a + b;      
            Console.WriteLine("Result is {0}", obj.Invoke(5,10));
        
            Console.ReadLine();
        }
    }
}
