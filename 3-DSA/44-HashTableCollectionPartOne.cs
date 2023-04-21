//----------------------------
// Hash Table Collection Part#1
//----------------------------

/*
1. Array is collection of homogeneous(same DT) elements & Collections is a collection of Hetrogeneous(different DT) elements.
2. Hash Table stores data in key(index)/value format same as array and arrayList. 
3. So what is difference b/w ArrayList/Array and HashTable?
4. ArrayList/Array keys are pre-Defined means you cannot explicitly define keys in ArrayList/Array [hum khud se apna index number nahi bana sakte ]
and HashTable keys are not predefined means you can explicitly define user defined keys in hashtable [apni marzi se hum keys define kar sakte hain. we can make string key, float key etc]
5. If we want to display employee data with array/ArrayList we can DISPLAY like this

1123								
“Adil”
“Manager”
25000
+923043102345
“Hyderabad”
“Unit No 7”
“June 2018”
    
For Exp: If I want to access city of employee I will count index number and this is major drawback as I cannot remember and count index number every time or if elements are more it would be difficult for me to count Index Number
    
Solution is that I will use HashTable and DISPLAY like this
    
Id: 1123
Name: “Adil”
Designation: “Manager”
Salary: 25000
ContactNo: +923043102345
City: “Hyderabad”
Address: “Unit No 7”
HireDate: “June 2018”

I can access City using key: City 
I dont have to remember index number 
*/

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
            Hashtable HT = new Hashtable(); //Syntax --> We can store different type of data inside HashTable

            HT.Add("ID", 1123);
            HT.Add("Name","Abdullah");
            HT.Add("IsMarried",false);
            HT.Add("Designation","Manager");
            HT.Add("Salary",25000.00);
            HT.Add("City","Lahore");
            HT.Add("Address","67-Y Block DHA");
            HT.Add("Contact No:","0304-5666689");
            HT.Add("Hire Date","10-12-2022");

            Console.WriteLine(HT["Salary"]); // Access Data 

            Console.ReadLine();
        }
    }
}

//One more Syntax

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
            Hashtable HT = new Hashtable() //Semi Colon remove karna hooga if you want to give body
            {
                {"ID", 112 },
                {"NAME","ALI"},
                {"Age",12},
                {1,32564},
                {2,64589}
            };

            Console.WriteLine(HT["Age"]);
            Console.WriteLine(HT[1]);

            Console.ReadLine();
        }
    }
}

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
            Hashtable HT = new Hashtable() 
            {
                {101,"Abdullah" },
                {102,"Ali" },
                {103,"Atif" },
                {104,"Shahid" },
                {105,"Salman" },
                {106,"Tariq" },
                {107,"Bushra" },
                {108,"Sameena" },
                {109,"Jalal" }
            };

            Console.WriteLine(HT[101]);
            Console.WriteLine(HT[102]);
            Console.WriteLine(HT[103]);
            Console.WriteLine(HT[104]);
            Console.WriteLine(HT[105]);
            Console.WriteLine(HT[106]);
            Console.WriteLine(HT[107]);
            Console.WriteLine(HT[108]);
            Console.WriteLine(HT[109]);
            Console.ReadLine();
        }
    }
}