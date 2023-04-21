//---------------------------------
//READING DATA FROM TEXT FILE
//---------------------------------

//We use this method ReadAllText

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
            string path = "C:\\Data.txt";  
            if(File.Exists(path))
            {
                Console.WriteLine("File Found");
                string Data = File.ReadAllText(path);  // Read All text from path and send it to Data 
                Console.WriteLine(Data);
            }
            else
            {
                Console.WriteLine("File Not Found");

            }
            Console.ReadLine();
        }
    }
}