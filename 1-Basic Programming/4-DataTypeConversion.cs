
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

            // DataType Conversion

            string num1 = "30";
            string num2 = "5";

            int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);

            Console.WriteLine(sum);

            //------------------------------------

            float c = 23.89f;
            int ans = (int)c;
            Console.WriteLine(ans);

            Console.ReadLine();

            //------------------------------------

            Console.WriteLine("Enter First Float Number:");
            float num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Float Number:");
            float num4 = float.Parse(Console.ReadLine());

            float answer = num3 + num4;

            Console.WriteLine(answer);
            Console.ReadLine();

            //------------------------------------

            // Constants

            //Constant Variable ko lazmi initialize karna hai 


            const float PI = 3.142f;
            Console.WriteLine(PI);

            const string Company_Name = "Abdullah_Company";
            Console.WriteLine(Company_Name);
            Console.ReadLine();

            float Force,Mass;
            const float acceleration = 9.81f;

            Console.WriteLine("ENTER YOUR MASS IN KILOGRAM TO FIND FORCE");
            Mass = float.Parse(Console.ReadLine());
            Force = Mass * acceleration;
            Console.WriteLine(Force + "N") ;

            Console.ReadLine();


        }
    }
}
