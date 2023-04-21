//----------------------------------------------------------------------
// Concept of Static Properties in C#
//----------------------------------------------------------------------

/*
 * 1. We use Static Keyword
 * 2. access using class name and period (.)
 * 3. No need to make object of that class
 * 4. We cannot use instance variable inside static property
 * 5. Static Property used to manipulate static fields of class in safe manner
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class university
    {
        private static string UniversityName;
        private static string UniversityDept;

        public static string _UniversityName
        {
            set
            {
                if(string.IsNullOrEmpty(value)==true)
                {
                    Console.WriteLine("Field Cannot Be Empty");
                }
                else
                {
                UniversityName = value;
                }
            }
            get
            {
                return UniversityName;
            }
        }
            
    }


    class Program
    {
        static void Main(string[] args)
        {
           // university._UniversityName = null;
            university._UniversityName = "PIA University";
            Console.WriteLine(university._UniversityName);
            
            Console.ReadLine();

          
        }

    }
}


//----------------------------------------------------------------------


/*
 * 1. We use Static Keyword
 * 2. access using class name and period (.)
 * 3. No need to make object of that class
 * 4. We cannot use instance variable inside static property
 * 5. Static Property used to manipulate static fields of class in safe manner
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class university
    {
        private static string UniversityName;
        private static string UniversityDept;
        // private string UniversityID; //cannot use this in static methods
        public static string _UniversityName
        {
            set
            {
                if(string.IsNullOrEmpty(value)==true)
                {
                    Console.WriteLine("Field Cannot Be Empty");
                }
                else
                {
                UniversityName = value;
                }
            }
            get
            {
                return UniversityName;
            }
        }

        public static string _UniversityDept
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please Enter Department Name");
                }
                else
                {
                UniversityDept = value;
                }
            }
            get
            {
                return UniversityDept;
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
           // university._UniversityName = null;
            university._UniversityDept = "Software Engineering";
            university._UniversityName = "PIA University";

            Console.WriteLine(university._UniversityName);
            Console.WriteLine(university._UniversityDept);
            
            Console.ReadLine();

          
        }

    }
}


