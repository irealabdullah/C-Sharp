//---------------------------------
//Checking File Exist Or Not In C#  
//---------------------------------

// Checking file exist or not in PC

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO; // we use this namespace 

namespace Myproject
{
    class program
    {        
        static void Main(string[] args)
        {
            string path = "C:\\Data.txt";  // we can use \\ or @
            if (File.Exists(path))
            {
                Console.WriteLine("File is present");
            }
            else
            {
                Console.WriteLine("File Not found");
            }
            Console.ReadLine();
        }
    }
}