
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
            DateTime T = DateTime.Now;

            Console.WriteLine("Date is {0:d}",T);
            Console.WriteLine("Date is {0:D}",T);
            Console.WriteLine("Date is {0:f}",T);
            Console.WriteLine("Date is {0:F}", T);
            Console.WriteLine("General Date is {0:g}", T);

            Console.WriteLine("Day is {0:ddd}", T);
            Console.WriteLine("Day is {0:dddd}",T);
            Console.WriteLine("Fractional Seconds are {0:FF}", T);
            Console.WriteLine("Hours In 24HRS Format {0:HH}", T);
            Console.WriteLine("Date is {0:MM}", T);
            Console.WriteLine("Month is {0:MMM}", T);
            Console.WriteLine("Seconds are {0:ss}",T);

            Console.WriteLine("{0:hh:mm:ss tt}",T);
            Console.WriteLine("{0:dd-MM-yyyy}",T);
            Console.ReadLine();

        }
    }
}
