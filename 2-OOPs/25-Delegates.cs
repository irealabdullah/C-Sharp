//---------------
// Delegates 
//---------------

/*
 1. DELEGATE MEANS NUMAINDA 
 2. WE USE THEM WITH METHODS 
 3. DELEGATE KE OBJECT MAIN HUM KISI BHI METHOD KA REFRENCE RAKHTE HAIN 
 4. IT IS ALSO CALLED A FUNCTION POINTER 
 5. IF WE WANT TO CALL A FUNCTION WE DONT CALL IT DIRECTLY WE USE DELEGATE TO CALL THEM INDIRECTLY
 6. DELEGATE WILL POINT THAT FUNCTION AND CALL IT --> THAT IS WHY IT IS CALLED FUNCTION POINTER 
 7. GATE OPEN -- BELL RING -- WE TELL OUR BROTHER TO OPEN 
 8. METHOD SIGNATURE MUST BE SAME WITH DELEGATE SIGNATURE
 9. we make object of delegate 
 10.when we make object of that delegate ->us ke constructor main error araha hooga so we will pass the method refrence in that constructor () jisko humne call karna hooga
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
    public delegate void Calculation(int x, int y); //We made a delegate with same signature of our method 
    
    class Program
    {
        public static void addition(int x,int y)  // we pass refrence of method in that delegate 
        {                                         // we use word static 
            int result = x + y;
            Console.WriteLine("Addition result is {0}",result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.addition);  // addition method show nahi karwa raha kyunke yeh upper wala hai instance method aur instance method ka object bana hoota hai 
             // and we are not making object of that method so we make the method static
            //two ways to call that function  
            obj.Invoke(10, 30); //  ------------> Method 1
            Program.addition(25, 30); //This is also a method to call
            Console.ReadLine();
        }
    }
}

//----------------------------------------------------------------------
//why we used delegate when we can call it with Program.addition(25, 30);

//1. method ko encapsulate karna aur usko indirectly call karna that is why we use delegate concept
//2. aik he delegate ke through we can call multiple methods 

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
        public static void addition(int x,int y)
        { 
            int result = x + y;
            Console.WriteLine("Addition result is {0}",result);
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
                                                                 
          
            obj.Invoke(10, 30);
            obj = Subtraction;  // see here we are passing refrence of subtraction method in our object
            Subtraction(25, 10); // aik he delegate ke through we are calling different methods 
            Console.ReadLine();
        }

    }
}

// we can also do like this --> Method 2 

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
        public static void addition(int x,int y)
        { 
            int result = x + y;
            Console.WriteLine("Addition result is {0}",result);
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
        static void Main(string[] args)  //Method 2 to call
        {
            Calculation obj = new Calculation(Program.addition);
            obj(10, 10);

            Calculation obj1 = new Calculation(Program.Subtraction);
            obj1(10, 10);

            Calculation obj2 = new Calculation(Program.Division);
            obj2(15, 5);

            Calculation obj3 = new Calculation(Program.Multiplication);
            obj3(25, 5);

            Console.ReadLine();
        }

    }
}

// delegate ke koi body nahi hooti { }
// delegate ko call karne ke 2 methods hain 
// we make object of delegate jis main method ka refrence hoota hai
// method aur delegate ke return type aur parameter same hoone chahiyee

//important point 

// jitna zaida hum delegate use karte hain utni zaida hamari application ke performance achi hooti hai .NET KA MANA HAI