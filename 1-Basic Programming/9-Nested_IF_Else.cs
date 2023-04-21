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
            if(marks>=90)
            {
                if(marks>=100)
                {
                    Console.WriteLine("Student Got A*");
                }
                else
                {
                    Console.WriteLine("Student Got A");
                }
            }
            else if(marks>=80)
            {
                Console.WriteLine("Student got B");
            }
            else if(marks>=70)
            {
                Console.WriteLine("Student got C");
            }
            else if(marks>=60)
            {
                Console.WriteLine("Student got D");
            }
            else if (marks >= 50)
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

//-----------------------------------------
//Outlook Application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Email Address: ");
            string Email = Console.ReadLine();
            if (Email == "irealabdullah@outlook.com")
            {
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (password == "Poloking123")
                {
                    Console.WriteLine("Login Successful..");
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                }
            }

            else
            {
                Console.WriteLine("Email is incorrect");
            }


            Console.ReadLine();
            

        }
    }
}



