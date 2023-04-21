//---------------------------------
// Understang concept of VAR KEYWORD
//---------------------------------

/*
 * 1. VAR KEYWORD KO INITIALIZE KARWANA ZAROORI HAI 
 * 2. VAR KEYWORD KE DATATYPE CHANGE NAHI KAR SAKTE BAAD MAIN
 * 3. INTELLISENCE WILL HELP US AS IT IS USED DURING COMPILE TIME
 * 4. VAR KEYWORD IS NOT USED AS RETURN TYPE AND AS A PARAMETER
 * 5. var keyword is value type
*/

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
            var v = "Abdullah";  
            //Console.WriteLine(v.Length);
            Console.WriteLine(v.GetType());
            Console.ReadLine();

        }
    }
}


//---------------------------------
// Understang concept of Dynamic KEYWORD
//---------------------------------

/*
 * 1. Dynamic KEYWORD KO INITIALIZE karwao ya nah karwao koi farak nahi parhta
 * 2. Dynamic KEYWORD KE DATATYPE CHANGE KAR SAKTE BAAD MAIN
 * 3. INTELLISENCE WILL NOT HELP US As IT IS USED DURING Run TIME
 * 4. Dynamic KEYWORD IS  USED AS RETURN TYPE AND AS A PARAMETER
 * 5. Dynamic keyword is refrence type
*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {

        public static dynamic display(dynamic a) //yeh kisi bhi tarhan ka data store kar sakta hai apne andar
        {
            
            return a;
        }
        public static void show(dynamic d) //yeh kisi bhi tarhan ka data store kar sakta hai apne andar
        {
            Console.WriteLine(d);
        }
        static void Main(string[] args)
        {
            Program.show(20);
            Program.show("Abdullah");
            Program.show(true);
            Program.show(27.35);

            Console.WriteLine(Program.display(10)); 

            dynamic d = 10;
            d = "Abdullah";
            Console.WriteLine(d.GetType()); //intellisense show nahi hoo ga 
            Console.ReadLine();


        }
    }
}

