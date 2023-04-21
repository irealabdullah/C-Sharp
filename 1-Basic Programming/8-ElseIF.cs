//Compiler har condition check karta 
//jab usko sahi condition mil jati tu bakion ko check nahi karta 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float marks;
            Console.Write("Enter Marks: ");
            marks = float.Parse(Console.ReadLine());
            if(marks >= 90 && marks <= 100)
            {
                Console.WriteLine("Student got A");
            }
            else if(marks >= 80 && marks < 90)
            {
                Console.WriteLine("Student got B");
            }
            else if (marks >= 70 && marks < 80)
            {
                Console.WriteLine("Student got C");
            }
            else if(marks >= 60 && marks < 70)
            {
                Console.WriteLine("Student got D");
            }
            else if(marks >= 50 && marks < 60) 
            {
                Console.WriteLine("Student got E");
            }
            else 
            {
                Console.WriteLine("Student got F");
            }

            Console.ReadLine();


        }
    }
}



