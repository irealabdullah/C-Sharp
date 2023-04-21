//----------------------------
// Constructor in Inheritence
//----------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_IN_Inheritence
{
    class parent
    {
       public parent()
        {
            Console.WriteLine("1.This is a Parent Class");
        }
    
    }
    class child:parent
    {
        public child()  // : base() ---> likho ya nah likh (doesnot matter)
            {
            Console.WriteLine("2.This is a Child Class");
            }
    }

    class Program
    {  
        static void Main(string[] args)
        {
            child c = new child();
            Console.ReadLine(); 
        }

    }  
}

/*
Jab hum inherit karte hain tab pehle parent class ka constructor chalta hai aur baad main child class ka
aisa kyun hoota hai? ----> woh iss liye kyunke child class ka constructor parent class ko pehle dawat deeta
hai ke pehle app chal jao phir main chaloon ga 

aur yeh ke child class ke constructor ke baad -----> base();  ---> yeh keyword likha hai isi wajah se 
pehle parent class ka constructor chale ga aur baad main child class ka constructor chale ga 
*/

//-----------------------------------------------------------------------------------------
// Why we need to use base() keyword after child class constructor when compiler already know ? 
//-------------------------------------------------------------------------------------------

/*we use base() keyword when parent class ke andar default constructor nah hoo 
paremetized constructor hoo 
yeh base() keyword sirf parent class ke default constructor ko call karsakta hai 
aur yeh ke jo bhi hum base() keyword ke andar likhain ge woh hamare parent class ke constructor main
chala jaye ga */

// Example


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_IN_Inheritence
{
    class parent
    {
       public parent(string message)
        {
            Console.WriteLine(message);
        }
    
    }
    class child:parent
    {
        public child() :base("1.This is a parent class")
            {
            Console.WriteLine("2.This is a Child Class");
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            Console.ReadLine(); 
        }

    }
}
