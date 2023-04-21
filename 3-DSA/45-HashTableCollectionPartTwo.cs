//----------------------------
// Hash Table Collection Part#2
//----------------------------

/*
Add: Adds an item with a key and value into the hashtable.
Remove: Removes the item with the specified key from the hashtable.
Clear: Removes all the items from the hashtable.
Contains: Checks whether the hashtable contains a specific key.
ContainsKey: Checks whether the hashtable contains a specific key.
ContainsValue: Checks whether the hashtable contains a specific value.
GetHashCode: Returns the hash code for the specified key.
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
            Hashtable HT = new Hashtable(); 

            HT.Add("ID", 1123);
            HT.Add("Name", "Abdullah");
            HT.Add("IsMarried", false);
            HT.Add("Designation", "Manager");
            HT.Add("Salary", 25000.00);
            HT.Add("City", "Lahore");
            HT.Add("Address", "67-Y Block DHA");
            HT.Add("Contact No:", "0304-5666689");
            HT.Add("Hire Date", "10-12-2022");

            //we can also use "Value" keyword instead of HT[KEY]

            foreach(object key in HT.Keys) //get all key from above and put it in key VARIABLE
            {
                //Console.WriteLine(key); //NOT SORTED WHEN PRINT COMES OUT 
                //Console.WriteLine(HT[key]);
                Console.WriteLine(key + ": " + HT[key]); //Both key and value will come as a print
            }

            // foreach(object value in HT.Values)
            // {
            //     Console.WriteLine(value);
            // }

            Console.ReadLine();
        }
    }
}

//using remove method we can remove our hash element

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
            Hashtable HT = new Hashtable(); 

            HT.Add("ID", 1123);
            HT.Add("Name", "Abdullah");
            HT.Add("IsMarried", false);
            HT.Add("Designation", "Manager");
            HT.Add("Salary", 25000.00);
            HT.Add("City", "Lahore");
            HT.Add("Address", "67-Y Block DHA");
            HT.Add("Contact No:", "0304-5666689");
            HT.Add("Hire Date", "10-12-2022");

            foreach(object key in HT.Keys) 
            {    
                Console.WriteLine(key + ": " + HT[key]); 
            }

            Console.WriteLine("------------------");

            HT.Remove("Salary"); //Removes Key = Salary 

            foreach (object key in HT.Keys)
            {
                Console.WriteLine(key + ": " + HT[key]);
            }

            Console.ReadLine();
        }
    }
}

//Clear Data

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
            Hashtable HT = new Hashtable(); 

            HT.Add("ID", 1123);
            HT.Add("Name", "Abdullah");
            HT.Add("IsMarried", false);
            HT.Add("Designation", "Manager");
            HT.Add("Salary", 25000.00);
            HT.Add("City", "Lahore");
            HT.Add("Address", "67-Y Block DHA");
            HT.Add("Contact No:", "0304-5666689");
            HT.Add("Hire Date", "10-12-2022");

            foreach(object key in HT.Keys) 
            {
                
                Console.WriteLine(key + ": " + HT[key]); 
            }

            Console.WriteLine("-----------------");

            HT.Clear(); // Will clear data in next loop 

            foreach (object key in HT.Keys)
            {
                Console.WriteLine(key + ": " + HT[key]);
            }

            Console.ReadLine();
        }
    }
}

//Contains or KeyContains // --> tells ke koi key hamare hash table main hai ke nahi hai 

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
            Hashtable HT = new Hashtable(); 

            HT.Add("ID", 1123);
            HT.Add("Name", "Abdullah");
            HT.Add("IsMarried", false);
            HT.Add("Designation", "Manager");
            HT.Add("Salary", 25000.00);
            HT.Add("City", "Lahore");
            HT.Add("Address", "67-Y Block DHA");
            HT.Add("Contact No:", "0304-5666689");
            HT.Add("Hire Date", "10-12-2022");

            Console.WriteLine(HT.Contains("address")); //return false as address is not available "Address" is available
            
            foreach (object key in HT.Keys) 
            {
              Console.WriteLine(key + " " + HT.Contains(key)); //tell you of if key is present or not
            }

            Console.WriteLine("-----------------");
            Console.ReadLine();
        }
    }
}

// Contains value 

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
            Hashtable HT = new Hashtable(); 

            HT.Add("ID", 1123);
            HT.Add("Name", "Abdullah");
            HT.Add("IsMarried", false);
            HT.Add("Designation", "Manager");
            HT.Add("Salary", 25000.00);
            HT.Add("City", "Lahore");
            HT.Add("Address", "67-Y Block DHA");
            HT.Add("Contact No:", "0304-5666689");
            HT.Add("Hire Date", "10-12-2022");

            Console.WriteLine(HT.ContainsValue("Abdullah")); //print if value is available or not           

            Console.ReadLine();
        }
    }
}

//**********************************************************
// GetHashCode: Returns the hash code for the specified key
//***********************************************************

// KEY      VALUE
// Name = "ABDULLAH"

//concept is that when we make element in hashTable there are 3 things [key -- value -- Hashcode]
// Key -- HashCode -- integer value --- 546548 

//Hash tables used Hashing algorithm To generate hash codes for every key And because of these hash codes Hash tables are faster than Array and ArrayList


// Get Hash code

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
            Hashtable HT = new Hashtable(); 

            HT.Add("ID", 1123);
            HT.Add("Name", "Abdullah");
            HT.Add("IsMarried", false);
            HT.Add("Designation", "Manager");
            
            Console.WriteLine("Abdullah".GetHashCode()); 
            
            Console.ReadLine();
        }
    }
}

/*
properties in Hashtable 
1. Count
2. Keys
3. Values
*/

// Count --> Count all the key values pair in hashtable

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
            Hashtable HT = new Hashtable(); 

            HT.Add("ID", 1123);
            HT.Add("Name", "Abdullah");
            HT.Add("IsMarried", false);
            HT.Add("Designation", "Manager");
            HT.Add("Salary", 25000.00);
            HT.Add("City", "Lahore");
            HT.Add("Address", "67-Y Block DHA");
            HT.Add("Contact No:", "0304-5666689");
            HT.Add("Hire Date", "10-12-2022");

            Console.WriteLine(HT.Count); //count all key values pair in hashtable
                      
            Console.ReadLine();

        }
    }
}