//-----------------------------------------
// Handling Null Refrence Exception 
//------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
           // string name = "Abdullah"; 
            string name = null;   // Here exception will come as length is null which is not possible 
            Console.ReadLine();
        }

    }
}

//--------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
                string name = null;
            try
            {
                Console.WriteLine(name.Length);
            }

            catch (NullReferenceException NRE)
            {

                Console.WriteLine("String is Null");
                Console.WriteLine(NRE.Message);                 
            }

            Console.ReadLine();
        }
    }
}