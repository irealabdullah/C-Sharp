//--------------------------
//	MULTICAST DELEGATES
//--------------------------

/*
 When a delegate is wrapped with more than one method that is known as a multicast delegate.
In C#, delegates are multicast, which means that they can point to more than one function at a time. They are derived from System.MulticastDelegate class.
We can use += and -= assignment operators to implement multi cast delegates.

aik object main multiple refrence dena --> isi ko multi cast delegate kehte hain

aik page ke ander 4 methods ko rakha and wrap it
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
    public delegate void Calculation(int x, int y);

    class Program
    {
        public static void addition(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Addition result is {0}", result);
        }
        public static void Subtraction(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Subtraction result is {0}", result);
        }
        public static void Multiplication(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Multiplication result is {0}", result);
        }
        public static void Division(int x, int y)
        {
            int result = x / y;
            Console.WriteLine("Division result is {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.addition);
            obj += Subtraction;  // AIK OBJECT HAIN AUR ISS MAIN MULTIPLE REFRENCE HAIN ADDITION BHI AUR SUBTRACTION BHI
            obj += Multiplication;
            obj += Division;
            obj += addition;
            obj(50, 5);
            Console.ReadLine();
        }

    }
}

// -= main iss ke ilawa sab dekaye dee ge