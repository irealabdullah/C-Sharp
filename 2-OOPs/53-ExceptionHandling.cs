//------------------
//  Exception
//------------------

/*
1. An exception is an event, which occurs during the execution of a program that disrupts the normal flow of the program's instructions. 
2. An exception is a C# object that represents an error.
Class ka object ForEXP: C# ne Divide by 0 ke name se aik class bana kar rakhi hai 
jab exception generate hooti hai tu uss class ka object banta hai aur woh throw hoo jata hai aur uss ko 
c# ka default Catch mechanism catch karta hai aur uss program ko band kar deta hai aur application ko terminate kardeta hai aur ugly message display karwa deta hai
aur uss exception ke baad baki statements ko execute nahi karta -- This above is Error Given by Compiler
we want that ke exception ko c# ka compiler handle nah kare. we deal with this exception

3. When a C# code raises an exception, it must either handle the exception immediately otherwise it terminates and quits. 
4. Exceptions are abnormal events that prevent a certain task from being 
    completed successfully.
   
5. When an exception occur 3 things happen
    1.	Program terminates or program crashes.
    2.	Ugly kind of error message is displayed that user can never ever understand.
    3.	Statements after exception will not be executed.

6. The exception handling in c# is one of the powerful mechanism to handle the runtime errors so that normal flow of the application can be maintained.
*/

/*
 In below code there is no exception and complete code is executed as we put num1 = 10 and <--> num2 = 5 <--> result = 2
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
            Console.Write("Ente Num1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ente Num2:");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2; // HERE ECEPTION CAN BE CREATED

            Console.WriteLine("Division Result is {0}", result);

            Console.WriteLine("Statement 1");
            Console.WriteLine("Statement 2");
            Console.WriteLine("Statement 3");
            Console.ReadLine();           
        }
    }
}

/*
if user puts 0 in num2 so compiler will generate Error so we will create exception 
so that compiler should not give us error and remaining lines also execute 
we handle the exception ourselves so that c# ka default compiler uss error ko catch nah kar sake
*/

/*
statement 1;  
statement 2;  
statement 3;  
statement 4;  
statement 5; //exception occurs   //below Lines will not Execute if there is error here
statement 6;  
statement 7;  
statement 8;  
statement 9;  
statement 10;
*/

//Programmer woh lines try block main rakhta hai jo lines usko lage error generate karain ge 
//we put these lines in try block so that we can catch them and c# doesnot catch it 

//Exception Handle by us 
//For Example Exception nahi ati tu phir catch block nahi chalta 

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
            Console.Write("Ente Num1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ente Num2:");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
            int result = num1 / num2;
            Console.WriteLine("Division Result is {0}", result);
            }

            catch(DivideByZeroException ex) //result iss refrence variable (ex) main store hoo jaye ga //DivideByZero is a class 
            {
                Console.WriteLine("You cannot divide by zero");
            }

            Console.WriteLine("Statement 1");
            Console.WriteLine("Statement 2");
            Console.WriteLine("Statement 3");
            Console.ReadLine();
        }
    }
}

//------------------------
//Error Message 
//------------------------

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
            Console.Write("Ente Num1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ente Num2:");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
            int result = num1 / num2;
            Console.WriteLine("Division Result is {0}", result);
            }

            catch(DivideByZeroException ex) 
            {
                Console.WriteLine("You cannot divide by zero");
                Console.WriteLine(ex.Message); // Error message displayed by C# Compiler // Every class have these error message 
            }

            Console.WriteLine("Statement 1");
            Console.WriteLine("Statement 2");
            Console.WriteLine("Statement 3");
            Console.ReadLine();
        }
    }
}