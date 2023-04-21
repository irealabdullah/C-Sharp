//------------------
//  List<T> Part#2
//------------------

//Can Accept Null and Duplicate Values

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

           List<string> list = new List<string>();
            list.Add("Abdullah");
            list.Add("Atif");
            list.Add("Irfan");
            list.Add("Salman");
            list.Add("Shahrukh Khan");
            list.Add("Umer");
            list.Add("Shahrukh Khan");
            list.Add(null);
            list.Add("Dawar");
            list.Add("Dawar");
            list.Add("Ammar");

            foreach (string EmpName in list)
            {
                Console.WriteLine(EmpName);
            }
            Console.ReadLine();
        }
    }
}

//Sort List in Ascending Order

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
            List<int> list = new List<int>();
            list.Add(44);
            list.Add(98);
            list.Add(35);
            list.Add(57);

            list.Sort();

            foreach (int EmpID in list)
            {
                Console.WriteLine(EmpID);
            } 
            Console.ReadLine();
        }
    }
}

/*
Capacity						
Count	

Add()				
AddRange()	//								
Insert()								
InsertRange()	

Remove()							
RemoveAt()		
RemoveRange()	 								
RemoveAll()	
*/