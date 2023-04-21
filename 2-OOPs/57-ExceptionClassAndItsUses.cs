//----------------------------
// Exception Class & Its Uses
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
            try
            {
                //******************************

                // string name = null;
                // Console.WriteLine(name.Length);

                //******************************

                //int[] arr = new int[3];
                //arr[0] = 11;
                //arr[1] = 12;
                //arr[2] = 13;
                //arr[3] = 13; //Exception will come 

                //******************************

                //string number = Console.ReadLine();
                //int num = int.Parse(number);
                //Console.WriteLine(number);
            }

            catch (Exception e) //Parent of All
            {
                Console.WriteLine(e.Message);  
            }
            Console.ReadLine();
        }
    }
}