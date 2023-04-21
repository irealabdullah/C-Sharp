//----------------------------
// Try Catch with Finally Block
//----------------------------

/*
1. Try aur catch ke sath use hone wala block is called finally block 
2. Try aur catch ke baad we write finally block 
3. Finally block lazmi execute hooga wheather excetion ayee ya nah ayee 
4. c# finally block is a block that is used to execute important code such as closing connection, stream etc,
5. Finally yah tu try ke sath hooga ya try catch ke sath hoo ga 
6. Finally is only used once 
7. Database connection hamain lazmi close karwana parhta hai apni application main chahe jo marzi hoo jaye
    Same Hamain File bhi lazmi close karwani parhti hai --> File Handling 
    agar main Database ka connection ya file close nahi karwaoon ga tu woh hamari memory main space leeti rahe ge 
*/

//-------------------------------------------------
// We will use finally block with try catch block
//-------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
			try
			{
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
			}

			catch (DivideByZeroException ex)
			{
                Console.WriteLine(ex.Message);
			}

            finally
            {
                Console.WriteLine("Finally block Executed..");
            }
               
            Console.ReadLine();
        }
    }
}

//-----------------------------------------
// We will use finally block with try block
//-----------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;  //Exception is handled by c# default compiler but still finally block will execute
                Console.WriteLine(c);
            }
            
            finally
            {
                Console.WriteLine("Finally block Executed..");
            }

            Console.ReadLine();
        }
    }
}

//CTRL + F5