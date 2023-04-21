//---------------
// Sealed Class
//---------------

/*
A sealed class is a class that prevents inheritance.  
The features of a sealed class are as follows:
A sealed class can be declared by preceding the class keyword with the sealed keyword. 
The sealed keyword prevents a class from being inherited by any other class.
The sealed class cannot be a base class as it cannot be inherited by any other class. 
If a class tries to derive a sealed class, the C# compiler generates an error. 

Purpose of Sealed Classes:
Consider a class named SystemInformation that consists of critical methods that affect the working of the operating system. 
You might not want any third party to inherit the class SystemInformation and override its methods, thus, causing security and copyright issues. 
Here, you can declare the SystemInformation class as sealed to prevent any change in its variables and methods.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    sealed class parent
    {
        public void show()
        {
            Console.WriteLine("This is a parent class");
        }
    }
    // class child : parent
    //{ }
    class Program
    {
        static void Main(string[] args)
        {

            parent p = new parent();
            p.show();
            Console.ReadLine();
        }

    }
}

