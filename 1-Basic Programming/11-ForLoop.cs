using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=5;
            for(int i=1;i<=10;i++)
            {
                int result=x*i;
                Console.WriteLine(x + "*" + i + "=" + result);
            }
            Console.ReadLine();
        }
    }
}

//For Loop ke jab tak condition true hai tab tak for loop chalta rahe ge
//jab Condition false hoo jaye ge tab for loop se bahir ajaye ga 

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
            Console.WriteLine("Find Integer table");
            Console.WriteLine();
            Console.Write("Enter an integer number: ");
            int integer_number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(integer_number + "*" + i + "=" + integer_number*i);
            }

            Console.ReadLine();

        }
    }
}


