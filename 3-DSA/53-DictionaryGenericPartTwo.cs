//------------------
//  Dictionary
//------------------

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
            Dictionary<int, string> MyDict = new Dictionary<int, string>();
            MyDict.Add(1,"Causing Great");
            MyDict.Add(2,"Causing Great");
            MyDict.Add(3,"Causing Great");
            MyDict.Add(4,"Causing Great");
            MyDict.Add(5,"Causing Great");

            Console.WriteLine(MyDict.Count); //Use of Count
            Console.ReadLine();  
        }
    }
}
