//---------------------
// Polymorphism in C#
//---------------------

/* 
1. Single Action is performed in many different ways
2. Poly means many & Morphs means forms --> Many forms 
3. Abdullah is a son, student, teacher and husband  
4. Types of polymorphism:
(a) Static Polymorphism (Compile Time Polymorphism) -->Compile time pe function ko object ke sath link karna is called early binding. it is also called static binding
(b) Dynamic Polymorphism (Run Time Polymorphism)
5. C# provides two techniques to implement static polymorphism. They are −
(a) Method Or Function Overloading
(b) Operator Overloading
6.  C# provides techniques to implement Dynamic polymorphism. They are −
(a) Method Overriding 
*/

//-------------------------------------------
// 1. Concept of Method Or Function Overloading
//-------------------------------------------


//Methods same name ke hoo sakte hain magar unka signature different hoona chahiye

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Sum
    {
        public void add()
        {
            int a = 5;
            int b = 5;
            int c= a + b;
            Console.WriteLine(c);

        }

        public void add(int x,int y)
        {
             
            Console.WriteLine(x + y);
        }

        public void add(float x,float y)
        {
            x = 10;
            y = 10;
            Console.WriteLine(x+y);

        }

        //public int add(int x,int y)  //yeh work nahi kare ga (void aur int signature main nahi atee )
        //{
        //    return x + y;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {  
            Sum s = new Sum();
            s.add();
            s.add(10, 15);
            Console.ReadLine();
          
        }

    }
}