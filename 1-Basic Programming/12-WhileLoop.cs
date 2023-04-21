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
        {
            int a = 1;
            while (a <= 10)   // only difference between for loop and while loop is syntax 
            {
                Console.WriteLine(a);
                a++;

            }
            Console.WriteLine("Loop Terminate");
            Console.ReadLine();
        }
    }
}


//While Loop ke jab tak condition true hai tab tak while loop chalta rahe ge
//jab Condition false hoo jaye ge tab while loop se bahir ajaye ga

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

            int i = 1,num=5;
            while(i<=10)
            {
                Console.WriteLine(num + "X" + i + "=" + num*i);
                i++;
            }
            Console.ReadLine();
        }
    }
}



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
            while (true)
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
                if (confirm == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Thanks for using our Calculator");
            Console.ReadLine();

        }

    }
}
