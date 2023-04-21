//Array is collection of element of single datatype
//aisa varaible jismain multiple values store hoo sakain
//Ram main elements ko memory location sath sath (adjecent) milti hai 

//--we use loops to access data from database as their are millions of records
//This is how we declare an Array
    
    //int[] age = new int[5];
    //int[] age = new int[] { 20, 30, 25, 65 };
    //string[] names = new string[] {"Ali","Abdullah","Arfat"};
    //int[] age = {20,30,25};

//when we declare array tab usko memory nahi milti when we run our program tab usko memory milti hai in ram
//Array is of refrence type 

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

        {  //Datatype -- array name -- assign array(age) memory in ram -- [5] size of array
            int[] age = new int[5];  //Declaration
            age[0] = 25;  //[0] index number 
            age[1] = 22;
            age[2] = 28; //Initialization
            age[3] = 21;
            age[4] = 20;

            Console.WriteLine(age[4]);
            Console.ReadLine();
        }
    }
}

//--------------------------------------------------------------------------
// ACCESSING ARRAY USING LOOPs IN C#
//--------------------------------------------------------------------------

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

            int[] Age = new int[10];

            Age[0] = 23;
            Age[1] = 67;
            Age[2] = 42;
            Age[3] = 16;
            Age[4] = 28;
            Age[5] = 18;
            Age[6] = 28;
            Age[7] = 58;
            Age[8] = 38;
            Age[9] = 28;

            for (int i = 0; i < Age.Length; i++)
            {
                Console.WriteLine(Age[i]);
            }

            Console.WriteLine(Age.Length);
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

       {
           string[] name = new string[3];

           name[0] = "Abdullah";
           name[1] = "Ali";
           name[2] = "Arfat";

           for (int i = 0; i < name.Length; i++)
           {
               Console.WriteLine(name[i]);
           }
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

            string[] NamesofStudent = new string[5];

            NamesofStudent[0] = "Abdullah";
            NamesofStudent[1] = "Haris";
            NamesofStudent[2] = "Butt";
            NamesofStudent[3] = "Ali";
            NamesofStudent[4] = "Salman";
            //NamesofStudent[5] = "AOC"; //System.IndexOutOfRangeException

            foreach (string item in NamesofStudent) //foreach loop is refrence type
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }

    }
}



//-------------------------------------------------------------------------------------------------
//SINGLE DIMENSION ARRAY
//-------------------------------------------------------------------------------------------------

// all above programs are single dimension array 

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
           int[] age = new int[3];
           age[0] = 20;
           age[1] = 10;
           age[2] = 15;

           for (int i = 0; i < age.Length; i++)
           {
               Console.WriteLine(age[i]);
           }
           Console.ReadLine();
       }

   }
}

//-----------------------------
//MULTI DIMENSION ARRAY
//-----------------------------

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
           int[,] age = new int[3, 2]
           { 
              //0  1
               {1, 2}, //0
               {3, 4}, //1
               {4, 5}, //2
           };

           Console.WriteLine(age.GetLength(0));

           Console.WriteLine(age[0, 1]);   //output 2
           Console.WriteLine(age[1, 1]);  //output 4
           Console.WriteLine(age[2, 1]); //output 5

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

       {
           int[,] age = new int[3, 2] // 3 rows and 2 column
           {  //0 //1
               {1, 2}, //0 index pe yeh row hai 
               {3, 4}, //1 index pe yeh row hai 
               {4, 5}, //2 index pe yeh row hai 
           };
           // I WANT TO ACCESS ALL THE DATA -> we use loops 

           for (int i = 0; i < age.GetLength(0); i++) // outer loop is for ROWS
           {
               for (int j = 0; j < age.GetLength(1); j++) // Inner loop is for COLUMNS
               {
                   Console.Write(age[i, j] + " ");
               }
               Console.WriteLine();

           }
           Console.ReadLine();

       }
   }
}

// we can also fetch data using foreach loop 
// jagged array --> Watch lec#35

//-------------------------------------------------------------------------------------------------
//Take Input From User in Array
//-------------------------------------------------------------------------------------------------

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
           Console.Write("Kitne loogon ka data store karwana hai: ");
           int n = int.Parse(Console.ReadLine());

           string[] name = new string[n];

           Console.WriteLine("Enter Your Data"); //or Console.WriteLine("Enter Your Data" + i) inside loop
           
           for (int i = 0; i < n; i++)
           {
               name[i] = Console.ReadLine();

           }
           Console.WriteLine("Your Data is:");  
           
           foreach (string item in name)
           {
               Console.WriteLine(item);
           }
           Console.ReadLine();

       }

   }
}
