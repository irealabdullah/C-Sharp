//----------------------------
// Throw KeyWord
//----------------------------

/*
 1. sometimes hum khud se exception throw karte hain and it is useful for our compiler
 2. Four Ways of Exception in C# 
    a. Default Throw and Default Catch --> Studied Previously when C# throw exception and C# compiler catch it
    b. Default Throw and Our Catch --> Studied Previously when C# throw exception and we catch it
   
    c. Our Throw and Default Catch  
    d. Our Throw and our Catch
*/

//-----------------------------
// OUR THROW AND DEFAULT CATCH
//-----------------------------

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
            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            if(age>18)
            {
                Console.WriteLine("You are not eligible to vote");
            }
            else
            {
                throw new Exception("You are not eligible to vote"); //THIS MESSAGE IS STORED IN MESSAGE PROPERTY 
            }
            Console.ReadLine();
        }
    }
}

//------------------------
// OUR THROW AND OUR CATCH
//------------------------

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
            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            try
            {
                if (age > 18)
                {
                    Console.WriteLine("You are not eligible to vote");
                }
                
                else
                {
                    throw new Exception("You are not eligible to vote"); //When we throw exception we use new keyword
                }
            }
            
            catch (Exception eXcP)
            {
                Console.WriteLine(eXcP.Message); 
                
            }       
            Console.ReadLine();
        }
    }
}

//------------------------
// OUR THROW AND OUR CATCH
//------------------------

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
            int account_Balance = 5000;
            int Withdrawl_Amount = 6000; // Withdrawl amount is higher than current balance 

            if(account_Balance<Withdrawl_Amount)
            {
                throw new Exception("Insufficient Balance..");
            }

            else
            {
                account_Balance = account_Balance - Withdrawl_Amount;
                Console.WriteLine("Your remaining balance is {0}",account_Balance);
                Console.WriteLine("Transaction Successful");
            }
            Console.ReadLine();
        }
    }
}

//upper wale aur neeche wale main difference hai 

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
            int account_Balance = 5000;
            int Withdrawl_Amount = 6000;

            try
            {
                if (account_Balance < Withdrawl_Amount)
                {
                    throw new Exception("Insufficient Balance..");
                }

                else
                {
                    account_Balance = account_Balance - Withdrawl_Amount;
                    Console.WriteLine("Your remaining balance is {0}", account_Balance);
                    Console.WriteLine("Transaction Successful");
                }
            }
            
            catch (Exception exc)
            {
                Console.WriteLine( exc.Message); 
            }
            
            Console.ReadLine();
        }
    }
}