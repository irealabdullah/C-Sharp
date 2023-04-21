//------------------------------------
// Concept of Static Constructor
//-------------------------------------

//A static constructor is used to initialize static variables of the class and to perform a particular action only once.
//Static constructor is called only once, no matter how many objects you create.
//Static constructor is called before instance (default or parameterized) constructor. 
//A static constructor does not take any parameters and does not use any access modifiers. 

//Only one static constructor can be created in the class. (doesnot follow constructor overloading concept)
//It is called automatically before the first instance of the class created. (automatically run before making object of that class)
//We cannot call static constructor directly.CLR(COMMON LANGUAGE RUNTIME)

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program
{
   class Person  
   {
       public static string PersonName;
       public static int PersonAge;
    
    static Person()   //we cannot use access modifiers and cannot use parameters in static constructor --> static constructor is only used to initialize static variables
        {
           PersonName = "Abdullah";
           PersonAge = 24;
           Console.WriteLine("Static Constructor Invoked !!");
        }

       public void getdetails()
       {
           Console.WriteLine("Person name is {0}", PersonName);
           Console.WriteLine("Person age is {0}", PersonAge);

       }

       public Person()
       {
           Console.WriteLine("Default Constructor Invoked");
       }
        static void Main(string[] args)
       {
           Person Abdullah = new Person();  // static constructor ...default constructor se pehle chal jaye ga aur values bhi initialize hoo jayen ge and after that default constructor chale ga
           Person Ali = new Person();
           //Abdullah.getdetails();
           Console.ReadLine();
       }
   }
}

//defalut construtor har object ke liye alehda alehda chale ga but static constructor uss se pehle chale ga 
