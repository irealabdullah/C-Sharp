// Jab hamara outer loop ke condition true hooti hai tab hamara inner loop chalta hai
// inner loop phir execute hoota rehta hai jab tab uski condition false nahi hoo jaa tii


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
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Outer Loop");

                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("Inner Loop");
                }
                Console.WriteLine("After Inner Loop");
            }

            Console.WriteLine("For Loop Terminates");
            Console.ReadLine();
        }
        
    }
}


