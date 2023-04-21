//-------------------------------------
//How To Create A Copy Of A File In C#
//-------------------------------------

// we use copy method 

/*
 Copy method have 2 overloaded versions.
    1st version takes 2 arguments.
    2nd version takes 3 arguments.

 1st version of Copy method does not allowed to overwrite file, 
 if you try to overwrite file then it throws exception.
 
 2nd version of Copy method allowed to overwrite file.
*/

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
            string path = "D:\\Data.txt";  
            string path2 = "D:\\Data1.txt";
            File.Copy(path, path2); // two arguments specify

            Console.ReadLine();
        }
    }
}