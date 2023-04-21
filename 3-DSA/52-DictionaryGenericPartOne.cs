//------------------
//  Dictionary
//------------------

/*
1. you dont need to count index number in dictionary as we did in hashtable but only difference is that we store data of same datatype in dictionary 
2. we store data in key value format where keys are user defined
3. Dictionary main hum same datatype ka data access karte hain aur apni keys dete hain to every element so that we dont count index number
4. How to store Data? -->  DICTIONARY<Tkey, Tvalue>   ||   DICTIONARY<int, int>
*/

//Syntax and Print Single Value

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
            Dictionary<string, string> MyDict = new Dictionary<string, string>();
            MyDict.Add("Active", "Causing Great");
            MyDict.Add("Amazing", "Causing Great");
            MyDict.Add("ABC", "Causing Great");
            MyDict.Add("AcDD", "Causing Great");
            MyDict.Add("Ace", "Causing Great");

            Console.WriteLine(MyDict["Active"]); //Print TValue
            Console.Read();
        }
    }
}

//Print All Values

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
            Dictionary<string, string> MyDict = new Dictionary<string, string>();
            MyDict.Add("Active", "Causing Great");
            MyDict.Add("Amazing", "Causing Great");
            MyDict.Add("ABC", "Causing Great");
            MyDict.Add("AcDD", "Causing Great");
            MyDict.Add("Ace", "Causing Great");

            foreach  (KeyValuePair<string,string> Store in MyDict )
            {
                Console.WriteLine(Store);
            }

            foreach  (KeyValuePair<string,string> Store in MyDict ) // we can also use var keyword
            {
                Console.WriteLine("Key is " + Store.Key + "Value is" + Store.Value );
            }
            Console.Read();
        }
    }
}

//Print Explicitly 

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
            Dictionary<string, string> MyDict = new Dictionary<string, string>();
            MyDict.Add("Active", "Causing Great");
            MyDict.Add("Amazing", "Causing Great");
            MyDict.Add("ABC", "Causing Great");
            MyDict.Add("AcDD", "Causing Great");
            MyDict.Add("Ace", "Causing Great");

            foreach  (String key in MyDict.Keys )  //Print only Keys
            {
                Console.WriteLine(key);
            }

            foreach (String values in MyDict.Values)  //Print only Values
            {
                Console.WriteLine(values);
            }
            Console.Read();
        }
    }
}

// Use int and string together

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
            MyDict.Add(1,"ali");
            MyDict.Add(2,"arfat");
            MyDict.Add(3,"abdullah");
            MyDict.Add(4,"salman");
            MyDict.Add(5,"moeez");

            foreach  (int key in MyDict.Keys ) //Print only Keys
            {
                Console.WriteLine(key);
            }

            foreach (string values in MyDict.Values) //Print only Values
            {
                Console.WriteLine(values);
            }
            Console.Read();
        }
    }
}