/*
types of methods
1. Built in -- c# compiler ne banaye hoote hain like int.parse(console.readline());
2. User defined -- developer makes 
3. methods perform specific tasks and are reusable 
4. methods ko hum main method main call karte hain aur methods ko hum class main banate hain
5. methods are stored in stack memory
*/

//--------------------------------------------------------------------------------------
//This is Non-static Function --> Call With Object name 
//--------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class Program
    {
        public void show() //Declaring a method/Function This is non-static method 
        {
            Console.WriteLine("Hello World");
        }

        static void Main(string[] args)

        {
            Program p = new Program();  // Making Object 
            p.show();
            Console.ReadLine();
        }
    }
}

//--------------------------------------------------------------------------------------
//How to call Static Function --> Call with Class Name
//--------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
   internal class Program
   {
        public void display() //This is non-static method 
        {
           Console.WriteLine("Hello World");
        }

        public static void show() //This is a Static Method
        {
           Console.WriteLine("Hello World");
        }

        static void Main(string[] args)

       {
           Program.show(); // static method ko class ke name ke sath call karte

           Program p = new Program(); //How we call non static function
           p.display(); 

           Console.ReadLine();
       }

   }
}

//--------------------------------------------------------------------------------------
//parameterized Function NOT TAKING INPUT from user
//--------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
   internal class Program
   {
       void display(int num1, int num2) //parameters
       {
           int result = num1 + num2;
           Console.WriteLine("Addition Result is:" + result);
       }

       static void Main(string[] args)
       {
           Program obj = new Program();

           obj.display(10, 20); //arguments
           obj.display(50, 20);
           obj.display(60, 20);
           Console.ReadLine();
       }
   }
}


//--------------------------------------------------------------------------------------
//Function TAKING INPUT FROM USER 
//--------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
   internal class Program
   {
       void display(int num1, int num2)
       {
           int result = num1 + num2;
           Console.WriteLine("Addition Result is:" + result);
       }

       static void Main(string[] args)
       {
           int NUM1, NUM2;
           Console.WriteLine("ENTER NUM1");
           NUM1 = int.Parse(Console.ReadLine());
           Console.WriteLine("ENTER NUM2");
           NUM2 = int.Parse(Console.ReadLine());

           Program obj = new Program();
           obj.display(NUM1, NUM2);



           Console.ReadLine();
       }


   }
}



//--------------------------------------------------------------------------------------
//Calling Static Method and Non-Static Method
//--------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
   internal class Program
   {
       public static void display()
       {
           Console.WriteLine("This is Static Function");
       }

       public void show()
       {
           Console.WriteLine("This is Non-Static Function");
       }

       static void Main(string[] args)
       {
           Program p = new Program();
           p.show();

           Program.display();
           Console.ReadLine();
       }


   }
}

//--------------------------------------
// Understanding concept of Named Argument
//--------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

   internal class Program
   {
       public void display(string name, int age)
       {
           Console.WriteLine("Your name is "+ name);
           Console.WriteLine("Your age is "+ age);
       }

       static void Main(string[] args)
       {
           Program p = new Program();
           p.display(age:24,name:"Abdullah"); //Named Arguments
           Console.ReadLine();

       }
   }
}


//--------------------------------------
// Understang concept of passing Argument
//--------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    internal class Program
    {
        public void display(string name)
        {
            Console.WriteLine("Your name is "+ name);
            
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            string n = "Abdullah";
            p.display(n);
            Console.ReadLine();

        }
    }
}