//----------------------------
// String and String Builder
//----------------------------

/*
* VERY IMP CONCEPT

1. String are immutable (means we cannot make changes) --> HEAP MEMORY MAIN WE CANNOT MAKE CHANGES 
    IF WE MAKE CHANGES THEN A NEW MEMORY BLOCK IN HEAP IS CREATED 
2. string s1 = “Adil”;    s1 Adil             0x92334 --> First memory block
    s1 = s1 + “ Ansari”;   s1 Adil Ansari      0x94644 --> Secondary memory block
    s1 = s1 + “ MCS”;      s1 Adil Ansari MCS  0x98524 --> Third memory block

WE WILL NOT USE STRING IF WE KNOW THAT CONSTANTLY DATA WILL CHANGE IN S1 BECAUSE IT WILL TAKE MORE SPACE IN
HEAP MEMORY AND MAKE MORE COPIES IN HEAP MEMORY
    
TO OVERCOME THIS WE USE STRING BUILDER

3. String Builder are mutable --> means we can make changes within the block -- No new block is made in heap 

4. Important points:
   *When you are doing few modifications only "String" is used
   *When we are doing more than 3-4 modifications or append then stringBuilder is preferred instead of string 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text; // String builder ke class ismain hai
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{   
    class program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Abdullah");
            sb.Append("Tariq"); // same memory block 
            sb.Append("Butt"); 
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Diagnostics;   //Here we use this headerfile for stopwatch

namespace Myproject
{ 
    class program
    {
        static void Main(string[] args)
        {
            string s1 = "Abdullah";

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();

            for (int i = 0; i < 100; i++)
            {
                s1 = s1 + i;
                Console.WriteLine(s1);
            }

            sw1.Stop();

            Console.WriteLine("-------------");

            Stopwatch sw2 = new Stopwatch();
            sw1.Start();

            StringBuilder sb = new StringBuilder("Hello");
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i);
                Console.WriteLine(i);
            }

            sw1.Stop();

            Console.WriteLine("Time taken by string {0}",sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken by stringBuilder {0}",sw2.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}

// 1000 milisec = 1 sec