//---------------------------------------
//	SINGLE CAST DELEGATES
//---------------------------------------
// 1. single Delegate --> Single method ko call kar raha hai aur we made one object of delegate  

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

    class Program
    {
        public static void addition(int x, int y)  // parameters same hoon tu acha hai magar different bhi hoo sakte hain
        {                                        
            int result = x + y;
            Console.WriteLine("Addition result is {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(addition);
            obj(100, 50);
            
            Console.ReadLine();
        }
    }
}
