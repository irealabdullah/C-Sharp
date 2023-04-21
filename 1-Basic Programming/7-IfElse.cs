using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.Write("Enter Any Integer Value:");
            num1=int.Parse(Console.ReadLine());
            Console.Write("Enter Any Integer Value:");
            num2 = int.Parse(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine(num1 + " is greater");
            }
            else
            {
                Console.WriteLine(num2 + " is greater");

            }
            Console.ReadLine();
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username:");
            string username = Console.ReadLine();
            Console.Write("Enter Password:");
            string password = Console.ReadLine();

            if (username == "irealabdullah" && password == "Poloking123") // We fetch data from database
            {
                Console.WriteLine("Login Successfull...");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }

            Console.ReadLine();
            

        }
    }
}



