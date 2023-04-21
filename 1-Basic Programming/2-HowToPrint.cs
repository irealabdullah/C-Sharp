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
            Console.Write("Enter Your First Name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Your name is {0} {1}",fname,lname);

            Console.Write("Enter your Cell Number:");
            int contact = int.Parse(Console.ReadLine());
            Console.Write("Your Cell Number is {0}", contact);

            Console.ReadLine();
        }
    }
}
