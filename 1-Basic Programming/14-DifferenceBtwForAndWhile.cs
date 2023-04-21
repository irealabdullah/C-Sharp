//1.First difference is of Syntax

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
            // 2.Second difference is that we cannot use i outside for loop but we can use j outside
            for (int i = 0; i < 10; i++) // we can declare i before for loop then use outside for loop 
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(i); //wrong

            Console.WriteLine("--------------");

            int j=0;
            while (j<10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine(j); //we can use it outside //answer is 10 as last value is 10 
            Console.Read();
        }
        
    }
}

//3. we use for loop when we know from where to start and where to end
// while loop is used when we only have condition. we dont know when it ends


