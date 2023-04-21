
//Delegates

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public delegate void calculation(int x, int y);  //Declare
     
    class Program
    {
        public static void addition(int x,int y)
        {
            int result = x + y;
            Console.WriteLine("Addition Result is {0}",result);
        }
        
        static void Main(string[] args)
        {
            calculation obj = new calculation(Program.addition); //Method ka refrence delegate ke object main store kia 
            obj(25, 25); // delegate ko objects pass kia 
            Console.ReadLine();
            
        }
    }
}

//Anonymous Function

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public delegate void calculation(int x, int y);
     
    class Program
    {  
        static void Main(string[] args)
        {
            calculation obj = delegate (int x, int y) //Anonymous Function 
            {
                int result = x + y;
                Console.WriteLine("Addition result is {0} ",result);
            };

            obj.Invoke(20, 30);
            Console.ReadLine();
        }
    }
}


//Lamda Expression

//Faltu cheezon ko hata do ge anonymous function main see tu lambda expression ban jaye ga 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public delegate void calculation(int x, int y);
     class Program
     {  
        static void Main(string[] args)
        {
            calculation obj = (x, y) => // Lamda Expression 
            {
                int result = x + y;
                Console.WriteLine("Addition result is {0} ",result);

            };

            obj.Invoke(20, 30);
            Console.ReadLine();
        }
    }
}



