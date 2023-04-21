//----------------------------
// Pram KeyWord
//----------------------------

/*
1. Param is an important keyword used as a parameter 
2. it is useful when programmer dont have knowladge how many parameters have to be passed
3. only one param is allowed in a method 
*/
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

namespace Myproject
{
    class Exp1
    {
        public static int add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exp1.add(10,50)); //we can only add two variables 
            Console.ReadLine();
        }
    }
}

//--------------------------------
//Now see the use of param keyword
//--------------------------------

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

namespace Myproject
{
    class Exp1
    {
        public static int add(params int[] numbers)  //Declaration of param keyword
        // we can only create only one param but we can make two parameters  
        {                                          
            int sum = 0;
            foreach (int printme in numbers)
            {
                sum = sum + printme;
            }
            return sum;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exp1.add(10, 50,50,60,90)); 
            Console.ReadLine();
        }
    }
}

//add multiple parameters 

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

namespace Myproject
{
    class Exp1
    {
        public static int add(int x,params int[] numbers) // Param hamesha last pe hoona chahieye // we can pass multiple parameters
        {                                                       
            int sum = 0;
            foreach (int printme in numbers)
            {
                sum = sum + printme;
            }
            return sum;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exp1.add(10, 50,50,60,90));  //10 passed to x and baki sab pass hoo jayen ge numbers ko
            Console.ReadLine();
        }
    }
}
 
/*
Important Note:
If we dont use param keyword then we have to pass array in main method and in add method
*/

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

namespace Myproject
{
    class Exp1
    {
        public static int add( int[] numbers) // just array
        {
            int sum = 0;
            foreach (int printme in numbers)
            {
                sum = sum + printme;
            }

            return sum;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40 }; //pass array
            Console.WriteLine(Exp1.add(arr));  
            Console.ReadLine();
        }
    }
}