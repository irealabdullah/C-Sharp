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
            //Arithemetic Operator 

            int a = 10 , b = 10 , c, d, e, f, g;

            c = a + b;
            d = a - b;
            e = a / b;
            f = a * b;
            g = a % b;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            Console.WriteLine();
            //Realtional Operator

            int A = 20, B = 30;
            bool C,D,E,F,G,H;

            C = A == B;
            D = A < B;
            E = A > B;
            F = A >= B;
            G = A <= B;
            H = A != B;

            Console.WriteLine(C);
            Console.WriteLine(D);
            Console.WriteLine(E);
            Console.WriteLine(F);
            Console.WriteLine(G);
            Console.WriteLine(H);

            Console.WriteLine();
            //Logical Operator

            int x = 10, y = 20;
            bool l = x < y || x > y;
            bool j = x < y && x > y;

            Console.WriteLine(l);
            Console.WriteLine(j);

            Console.WriteLine();
            //Assignment Operator

            int value = 10, w = 20;

            value += 10; // value = value + 20;
            value *= w; // value = value * 20;
            value -= w;// value = value - 20;
            value /= w;
            value %= w;

            Console.WriteLine(value);


            Console.WriteLine();
            //Increment Decrement Operator

            // PreFix

            int num =10, k;
            k = ++num;
            Console.WriteLine(num); //11
            Console.WriteLine(k); //11

            //  PostFix
            int num2 = 10, k2;
            k2 = num2++;
            Console.WriteLine(num2); //11
            Console.WriteLine(k2);//10

            Console.WriteLine();

            Console.WriteLine();
            //Tenary Operator

            int a = 10, b=20;
            string c = (a>b)? "A is Greater":"B is greater";
            Console.WriteLine(c);

            //Precedence Of Operators--> BODMASS

            int solve = 8 / 2 - 3 + 2 * 2;
            Console.WriteLine(solve);

            Console.Read();

        }
    }
}




//------------------------------------------------
//Not Operator
//------------------------------------------------
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

       int num;
       Console.WriteLine("Enter a number from 1-10:");
       num=int.Parse(Console.ReadLine());
       if(!(num > 0 && num <= 10))
       Console.WriteLine(" Your number is between 1 and 10 ");
       else
       Console.WriteLine("Your number is not between 1 and 10");
       Console.ReadLine();
       }
   }
}

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

            int num;
            Console.Write("Enter any integer positive value:");
            num=int.Parse(Console.ReadLine());
            if(!(num==0))
            {
                Console.WriteLine("This is 0");
            }
            else
            {
                Console.WriteLine("This is not 0");
            }
            Console.ReadLine();

        }
    }
}


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

            int num;
            Console.Write("Enter Integer value 10 to check statement is true or False:");
            num=int.Parse(Console.ReadLine());
            if(!(num==10))
            {
                Console.WriteLine("Statement is False");
            }
            else
            {
                Console.WriteLine("Statement is true");
            }
            Console.ReadLine();

        }
    }
}


//--------------------------------
// And Operator
//--------------------------------

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

            int num;
            Console.Write("Enter Integer value between 0-100 to check statement is true or False:");
            num=int.Parse(Console.ReadLine());
            if(num>0&&num<=50)
            {
                Console.WriteLine("Integer value is between 0-50");
            }
            else
            {
                Console.WriteLine("Integer value is between 50-100");
            }
            Console.ReadLine();

        }
    }
}


//------------------------------------
// OR Operator

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

            int num;
            Console.Write("Enter Integer value between 0-100 to check statement is true or False:");
            num=int.Parse(Console.ReadLine());
            if(num>0||num<=50)
            {
                Console.WriteLine("Integer value is between 0-50");
            }
            else
            {
                Console.WriteLine("Integer value is between 50-100");
            }
            Console.ReadLine();

        }
    }
}


//-------------------------------------
//Tenary Operator

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

           int num;
           Console.Write("Enter Integer value:");
           num=int.Parse(Console.ReadLine());
           var result = num == 0 ? "Number is 0" : "   Number is not 0";
           Console.WriteLine(result);
           Console.ReadLine();
       }
   }
}

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
            int x = 10, y = 100;

            string result = x > y ? "x is greater than y" :
                                x < y ? "x is less than y" :
                                    x == y ? "x is equal to y" : "No result";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}







