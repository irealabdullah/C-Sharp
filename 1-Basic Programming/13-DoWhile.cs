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
       static void Main(string[] args)
       // Important Program
       {
           string confirm;
           do
           {
               int x, y, sum;
               Console.Write("Enter First Integer_Number: ");
               x = int.Parse(Console.ReadLine());
               Console.Write("Enter Second Integer_Number: ");
               y = int.Parse(Console.ReadLine());
               sum = x + y;
               Console.WriteLine("Sum" + " = " + sum);
               Console.WriteLine("Do you Want to Repeat your Program? \n Enter Yes/No ");
               confirm = Console.ReadLine().ToLower();
           }
           while (confirm == "yes");

           Console.WriteLine("Thankyou For Using Our Calculator");
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
            int i = 0;
            do
            {
                Console.WriteLine("Abdullah");
                i++;
            } 
            while (i<=10);

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
            int i = 1; 
            do
            {
                Console.WriteLine("Abdullah");
                i++;
            } 
            while (i<0); // condition false hai phir bhi aik dafa condition execute hoo ge

            Console.ReadLine();
        }
        
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confirm;
            do
            {
                Console.WriteLine("Welcome To Calculator");
                Console.WriteLine();

                Console.WriteLine("Enter Num1:");
                int num1=int.Parse(Console.ReadLine());

                Console.WriteLine("Choose Operator [*, -, /, +]");
                char operatoR = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter Num2:");
                int num2 = int.Parse(Console.ReadLine());


                switch (operatoR)
                {
                    case '*':
                        Console.WriteLine(num1*num2);
                        break;

                    case '+':
                        Console.WriteLine(num1+num2);
                        break;

                    case '-':
                        Console.WriteLine(num1-num2);
                        break;

                    case '/':
                        Console.WriteLine(num1/num2);
                        break;

                    default:
                        Console.WriteLine("Please choose correct operator");
                        break;
                }

                Console.WriteLine("Do you want to reuse our Calculator: Enter Yes/No");
                confirm = Console.ReadLine().ToLower();
            }
            while(confirm == "yes");

            Console.ReadLine();
        }
        
    }
}


