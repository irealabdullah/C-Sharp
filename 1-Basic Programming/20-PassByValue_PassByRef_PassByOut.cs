// ---------------------------------
// Understang concept of Pass by value
// ---------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   internal class Program
   {
        public static void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            int value = 5; 
            Program.PassByValue(value); //Output: 15  // Copy send to function
            Console.WriteLine("Value send to Function " + value); // Output: 5

            Console.ReadLine();
        }
   }
}



//---------------------------------------
// Understang concept of Pass by Refrence
//---------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        public static void PassByRefrence(ref int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int value = 10; //whole memory block is given to the above method  agar hum isko aise likhain int value; tu error ajaye ga  
                                  
            PassByRefrence(ref value);  // result is 20
            Console.WriteLine(value);   // result is 20
            Console.ReadLine();

        }
    }
}


//---------------------------------
// Understang concept of Pass by out
//---------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        public static void passbyout(out int a)
        {
            a = 20;
            Console.WriteLine(a);
        }


        static void Main(string[] args)
        {
            int value;   //isko value 20 mil jaye ge in function kyunke we used out keyword 
            passbyout(out value);   
            Console.WriteLine(value);
            Console.ReadLine();

        }
    }
}
