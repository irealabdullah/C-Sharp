//----------------------------
// Handling Format Exception
//----------------------------

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
            Console.WriteLine("Enter a Number:");
            string number = Console.ReadLine();

            try
            {
            int num = int.Parse(number); //Here exception is coming as user put string value in number 
            Console.WriteLine(num);
            }

            catch (FormatException FE)
            {
                Console.WriteLine("Enter Integer value");
                Console.WriteLine(FE.Message); 
            }
            Console.ReadLine();
        }
    }
}
