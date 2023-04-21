//-----------------------
// Generics in C#
//-----------------------

/*
1. Genric allows you to write a class or method that can work with any datatype
2. You can create your own generic interfaces, classes, methods, events, and delegates.
3. You may get information on the types used in a generic data type at run-time.

Generics can be applied to the following:
1. Interface
2. Abstract class
3. Class
4. Method
5. Static method
6. Property
7. Event
8. Delegates
9. Operator

Advantages of Generic:
1. Increases the reusability of the code.
2. Generic has a performance advantage because it removes the possibilities of boxing and unboxing.
3. Aik se zaida generic type parameter de sakte hain <T,S>
4. you can declare generic method within generic or non generic class

5.Generic methods can be declared with the following keywords:
Virtual -- these methods can be generic
Override -- these methods can be generic
Abstract- - these methods can be generic
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
    class student
    {
        public static void showArray(int[] arr) // if user pass 3 tu 0-2 tak chale ga  
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void showArray(string[] arr)  
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            int[] age = new int[3];
            age[0] = 22;
            age[1] = 33;
            age[2] = 44;

            string[] names = new string[3];
            names[0] = "Abdullah";
            names[1] = "Ali";
            names[2] = "Arfat";

            student.showArray(age);
            Console.WriteLine("--------------------");
            student.showArray(names);
            Console.ReadLine();
        }
    }
}

//----------------------
// Concept of Generics
//----------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class student
    {
        public static void showArray<T>(T[] arr) //ANGULAR BRACKETS<> // PLACEHOLDER OF GENERIC : T
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            int[] age = new int[3];
            age[0] = 22;
            age[1] = 33;
            age[2] = 44;

            string[] names = new string[3];
            names[0] = "Abdullah";
            names[1] = "Ali";
            names[2] = "Arfat";

            // string[] names = { "Abdullah", "Ali", "Arfat"};
            
            double[] points = { 6.2, 32.65, 52.4 };

            long[] numbers = { 456456, 516515565, 665464654 };
           
            student.showArray(age);
            Console.WriteLine("--------------------");
            student.showArray(names);
            Console.WriteLine("--------------------");
            student.showArray(points);
            Console.WriteLine("--------------------");
            student.showArray(numbers);

            Console.ReadLine();
        }
    }
}

//Type safety

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Example
    {
        //public static bool check(int a,int b) // we use generics so that it can accept multiple datatypes
        //{
        //    bool c = a.Equals(b);
        //    return c;
        //}

        public static bool check<T>(T a, T b) // T type ka a aur b hai //now we can send every datatype
        {
            bool c = a.Equals(b);
            return c;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Example.check(10, 10));
            Console.WriteLine(Example.check(20, 10));
            Console.WriteLine(Example.check("Ali", "Ali")); //Replaces with a & b
            Console.ReadLine();
        }
    }
}

//Check Datatype 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Example
    {
        public static void Check<T>(T a) 
        {
            Console.WriteLine(typeof(T));
        }
    }
    class program
    {
        static void Main(string[] args)
        {    
            Example.Check(10);
            Example.Check(20);
            Example.Check("Ali");
            Console.ReadLine();
        }
    }
}

//------------------------------------------------
//boxing and unboxing
//------------------------------------------------

// Boxing --> value type Console.WriteLine(Example.check(10, 10)); ko convert karna refrence type main (object a, object b) 
// Boxing is not good for our application performance so we will avoid boxing and unboxing and we use generics

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Example
    {
        public static bool check(object a, object b) 
        {
            bool c = a.Equals(b);
            return c;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Example.check(10, 10));
            Console.ReadLine();
        }
    }
}

