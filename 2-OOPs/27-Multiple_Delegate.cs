//--------------------------
//	MULTIPLE DELEGATES
//--------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    public delegate void Calculation(int x, int y);
    public delegate void Calculation2(int num);
    public delegate void show();
    class Program
    {
        public static void display()
        {
            Console.WriteLine("This is a show method...");
        }
        public static void square(int num)
        {
            int square = num * num;
            Console.WriteLine("Sqaure of {0} is {1}",num,square);
        }

        public static void cube(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("Cube of {0} is {1}", num, cube);
        }

        public static void addition(int x, int y)  // parameters same hoon tu acha hai magar different bhi hoo sakte hain
        {                                        
            int result = x + y;
            Console.WriteLine("Addition result is {0}", result);
        }

        static void Main(string[] args)
        {
            //Calculation obj = new Calculation(addition);
            //obj(100, 50);
            //show o = new show(display);
            //o.Invoke();
            Calculation2 cal = new Calculation2(cube);
            cal.Invoke(10);

            cal = square;
            square(10);
   
            Console.ReadLine();
        }
    }
}

