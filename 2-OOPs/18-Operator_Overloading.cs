//-----------------------------
// 2. Operator Overloading
//-----------------------------

/*
•	1. The concept of overloading a function can also be applied to operators.
•	2. Operator overloading gives the ability to use the same operator to do various operations.
•	3. It provides additional capabilities to C# operators when they are applied to user-defined data types.
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
    class random
    {
        public string name;
        public int num;

        public static random operator + (random obj1 , random obj2)
        {
            random obj3 = new random();
            obj3.name = obj1.name + obj2.name;
            obj3.num = obj1.num + obj2.num;
            return obj3;
 

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            random obj1 = new random();
            obj1.name = "Ali ";
            obj1.num = 10;

            random obj2 = new random();
            obj2.name = "Tariq";
            obj2.num = 20;

            random obj3 = new random();
            obj3 = obj1 + obj2;
            Console.WriteLine(obj3.name);
            Console.WriteLine(obj3.num);

            Console.ReadLine();
        }

    }
}


