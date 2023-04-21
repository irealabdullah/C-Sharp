using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{

    internal class Program
    {
        public static double Subtraction(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void addition(int x,int y)
        {
            int result = x + y;
            Console.WriteLine("Addition Result is {0}",result);
        }

        public static bool checklength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }

        // Three types of Generic Delegates
        // 1. Func
        // 2. Action
        // 3. Predicate

        static void Main(string[] args)
        {
            Func<int, float, double, double> obj = Subtraction;
            Console.WriteLine(obj.Invoke(20, 93, 20.75));
            

            Action<int, int> obj2 = addition;
            obj2.Invoke(25, 30);

            Predicate<string> obj3 = checklength;
            bool status = obj3.Invoke("Holla");
            Console.WriteLine(status);
            Console.ReadLine();
            

            Console.ReadLine();
        }
    }
}


// If we want to reduce size of above program we use LAMDA EXPRESSION
// Benifit is that we dont need to mention Functions 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{

    internal class Program
    {
       
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj = (x,y,z) => x-y-z;
            Console.WriteLine(obj.Invoke(20, 93, 20.75));

            Action<int, int> obj2 = (x,y) => Console.WriteLine(x+y);
            obj2.Invoke(25, 30);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status = obj3.Invoke("Hello");
            Console.WriteLine(status);


            Console.ReadLine();
        }
    }
}
