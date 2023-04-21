//-----------------------
// String Builder Class
//-----------------------

/*
StringBuilder can be initialized the same way as class.
    Example: 
    StringBuilder sb = new StringBuilder(); 
    or
    StringBuilder sb = new StringBuilder("Hello World!!");

2. You can give an initial capacity of characters by passing an int value in the constructor. By default its 16 characters.

    EXAMPLE OF TWO SYNTAX : 
    
    StringBuilder sb = new StringBuilder(50); //ByDefault initial capacity is 16 
                                             //if you give initial capacity 16 -- size 32 ho jaye ga --DOUBLING 
    or
    
    StringBuilder sb = new StringBuilder("Hello World!!",50); //String and then initial capacity
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Diagnostics;

namespace Myproject
{
   
    class program
    {
        static void Main(string[] args)
        {
            //Append
            StringBuilder obj = new StringBuilder("Abdullah ");
            obj.Append("Tariq ");
            obj.Append("Butt");
            //Console.WriteLine(obj);

            //AppendLine
            StringBuilder obj1 = new StringBuilder("Abdullah "); //this is append
            obj1.AppendLine("Tariq"); //this is appendLine
            obj1.AppendLine("Butt");
            //Console.WriteLine(obj1);

            //AppendFormat
            StringBuilder obj2 = new StringBuilder();
            obj2.AppendFormat("{0:C}", 25); // C is currency // we are making 25 --> 25$ and then we are appending
            obj2.AppendFormat("{0:N}", 25); // without currency sign
            obj2.AppendFormat("{0:X}", 25); //Hexadecimal value
            Console.WriteLine(obj2);

            //Insert() String Builder 
            StringBuilder obj3 = new StringBuilder("Abdullah");
            obj3.Insert(7,"Butt");
            Console.WriteLine(obj3);

            //Remove() String Builder
            StringBuilder obj4 = new StringBuilder("Hello World");
            obj4.Remove(6, 5); //6  is from where to start and 5 character will be removed
            Console.WriteLine(obj4);

            //Replace() String Builder
            StringBuilder obj5 = new StringBuilder("Hello World");
            obj5.Replace("World","C#"); 
            Console.WriteLine(obj5);
            Console.ReadLine();

            //ToString() 
            StringBuilder obj6 = new StringBuilder("Hello World"); //Convert StringBuilder to String
            string s1 = obj6.ToString();
            Console.WriteLine(s1);
        }
    }
}

/*
1. StringBuilder is mutable.
2. StringBuilder performs faster than string when appending multiple string values.
3. Use StringBuilder when you need to append more than three or four strings.
4. Use Append() method to add or append strings with StringBuilder.
5. Use ToString() method to get the string from StringBuilder.
6. It is available in System.Text namespace
*/