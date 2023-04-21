//Break Statement 
/*
1. Loop se bahir niklana hoo we use break statement 
2. we use jump statements in for loop and with if statements
3. Jump statemenets are used to transfer control from one point to another 
*/

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
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Value of i is {0}",i);

                if(i == 5)
                {
                    break; 
                }
            }

            Console.WriteLine("Loop Terminates");
            Console.ReadLine();
        }
        
    }
}

//output 1 2 3 4 5 loop terminates



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
            for (int i = 1; i < 10; i++)
            {
              
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine("Value of i is {0}", i);         
            }

            Console.WriteLine("Loop Terminates");
            Console.ReadLine();
        }

    }
}

//output 1 2 3 4  loop terminates

// -------------------------------------------------------------

//Continue 
/*
 1. Continue skip kar deta hai current iteration ko aur agee ka poora loop chalaye ga see example below *@
 */

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
            
            for (int i = 0; i < 10; i++)
            {
                if (i==5) //*@   //it will skip this iteration 5 and jump to next iteration 6 then 7 then 8 so on until loop condition is false
                { 
                    continue; 
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");
            Console.ReadLine();
        }

    }
}

// output 0 1 2 3 4 6 7 8 9  -----------------


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
             //Print odd numbers
            for (int i = 0; i < 10; i++)
            {
                if (i == 0|| i == 2 || i == 4 || i == 6 || i == 8) //Print odd Numbers
                { 
                    continue; 
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");
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
            //Print odd numbers
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) // i ko divide karo 2 ke sath aur agar yeh remainder deta hai 0 then continue(skip this iteration) 
                { 
                    continue; 
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");
            Console.ReadLine();
        }

    }
}

// -------------------------------------------------------------

//goto statement 

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
            for (int i = 1; i < 10; i++)
            {

                if (i == 5)
                {
                    goto stop; // got to ---> 'Stop' Label pe jaye ga direct 
                }
                Console.WriteLine(i);

            }

            Console.WriteLine("Loop Terminated");

        stop: //we can give name of label by ourself 
            Console.WriteLine("PROGRAM EXIT");
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
            int i = 1;

            while (i<=100)
            {
                Console.WriteLine(i);
                i++;
                if (i==51)
                {
                    goto comehere;
                }
            }

            Console.WriteLine("We are outside while loop");

        comehere:

            Console.WriteLine("Successfully printed 50 values");
            Console.ReadLine();


         
        }

    }
}