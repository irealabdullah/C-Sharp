//-----------------------------------------
// Handling Index Out Of Range Exception
//------------------------------------------

//This Exception [Handling Index Out Of Range Exception] comes when we work with array 

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
            int[] arr = new int[3];
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;

            //arr[3] = 44;  Here Exception will come as Array limit has been increased  
            

            foreach (int Printme in arr)
            {
                Console.WriteLine(Printme);
            }

            Console.ReadLine();
        }
    }
}

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
            int[] arr = new int[3];

            try //jo lines par exeption a sakti hai unko hum iss try block main rakahain ge 
            {
                arr[0] = 11;
                arr[1] = 22;
                arr[2] = 33;
                arr[3] = 44; // Jab yahan exception ati hai tu hamara code CATCH Block ko transfer Hoo jata hai aur loop nahi chalta 

                foreach (int Printme in arr)
                {
                    Console.WriteLine(Printme);
                }
            }

            catch (IndexOutOfRangeException obj)
            {
                Console.WriteLine("Array out of range"); // Either you can give your own message or 
                Console.WriteLine(obj.Message); // we can give C# message 
            }           
            Console.ReadLine();
        }
    }
}