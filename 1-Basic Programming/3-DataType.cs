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
            Console.WriteLine(float.MinValue + " " + float.MaxValue);
            Console.WriteLine(int.MinValue + " " + int.MaxValue);
            Console.WriteLine(double.MinValue + " " + double.MaxValue);

            int a = 10;
            int b = 20;

            //----------------------------
            bool c = a<b ;
            Console.WriteLine(c);

            //----------------------------

            float num = 10.28f;
            double num1 = 10.3867d;
            decimal num2 = 2378.234324m;

            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            //----------------------------

            string name = "Abdullah";
            char C = 'A';

            Console.WriteLine(name);
            Console.WriteLine(C);

            //----------------------------

            Console.WriteLine("Your name is \"Abdullah\""); //Escape Sequence
            Console.WriteLine("Your name is \\Abdullah\\");

            Console.WriteLine("D:\\User\\Abdullah\\Project");
            Console.WriteLine(@"D:\User\Abdullah\Project"); //Verbatim Literals 

            Console.ReadLine();
            
        }
    }
}
