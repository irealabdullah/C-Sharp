//----------------------------
// Collections And Array List:
//----------------------------

/*
1. Alag Alag Datatype ka Data hum store karwa sakte hain Collection main
2. Array ka size fix rehta hai but --> collection ka size dynamically changes 
3. Collection is a Dynamic Array --> Its length can increase on runtime
4. Collection main concept hai AUTO RESIZING JIS MAIN HUM apna DATA INSERT KAR rahe hain aur automatically SIZE increase hoota jaa raha hai collection ka 
7. Normal ARRAY LENGTH IS FIXED AND WE CANNOT CHANGE AFTER DECLARING IT 
8. THERE IS METHOD CALLED --> Array.Resize() 
9.	We can never insert a value into a middle of an array, because if we want to do this then array length should be increased but we cannot increase the length of an array after declaring the length of an array. --- that is why we use collections
10.	We can never delete a value from a middle of an array. --- that is why we use collections
11. jis tarhaan hum array ke index pe value store karwate hain same hum collection ke index pe value store karwate hain 
*/

using System;
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
            int[] age = new int[3];

            age[0] = 22;
            age[1] = 25;
            age[2] = 27;  // 0-2 tak ka size hai 

            // age[3] = 29; we cannot make this as it will give exception and throw us error as it doesnot match array size
            Console.ReadLine();
        }
    }
}

// Solution is that we use this method called ---> Aray.Resize()

using System;
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
            int[] age = new int[3];

            age[0] = 22;
            age[1] = 25;
            age[2] = 27;

            Array.Resize(ref age, 4); //we are changing size of array 

            // Array.Resize() method backend pe pehle wale array jiski length 3 hai usko destroy kar raha hai 
            // aur aik new array bana raha hai usi name se ussi address ke upper but length uski 4 rakh raha hai 

            age[3] = 29;
            Console.ReadLine();
        }
    }
}

/*
Differeces b/w Array and Collections:
ARRAY	                                                   COLLECTION
1) Cannot be resized at run-time.	                       |1)  Can be resized at run-time.
2) The individual elements are of the same data type.	   |2)  The individual elements can be of different data types.
3) we cannot add and delete elements in middle .           |3)  we can add and delete elements in middle
4) We can never insert a value into a middle of an array.  |4)  We can insert a value into a middle of a collection. --> Auto Resize mechanism --changes array size
5) We can never delete a value from a middle of an array.  |5)  We can delete a value from a middle of a collection.
*/
//---------------------
/*
1)	Collections were introduced in C# 1.0
2)	We have two kinds of Collections: (Today we use)

o Non-Generic collections:
Stack, ArrayList, Hashtable, SortedList etc.
System.Collections --> namespace have non-generic collections.
Array list is most commonly used in market

o Generic collections:
List<T>, LinkedList<T>, Queue<T>,SortedList<T,V>.
System.Collections.Generic --> namespace have generic collections.

//-----------------------------------------------------------------------

Generic Collection(new)                 vs                          NonGeneric Collection(old)

List<T> and LinkedList<T>                                           ArrayList      
Dictionay<TKey,TValue> and sorted dictionary<TKey,TValue>           HashTable
Queue<T>                                                            Queue
Stack<T>                                                            Stack
SortedList<TKey,TValue>                                  
HashSet<T> and SortedSet<T> 
.                                                                   Array[]
*/

// Difference b/w Array and ArrayList

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
            ArrayList MyList = new ArrayList(); //Dynamic Array in which we can store any type of data

            MyList.Add(10); // yeh add ka function first_cell_pe/0 index pe hamara data store karwade ga
            MyList.Add("Abdullah"); //See it can also store string datatype
            MyList.Add("ali");
            MyList.Add(3.25);
        }
    }
}

//--------------------------------------------------------------------------
//Lets see length of out ARRAY LIST ---> ArrayList MyList = new ArrayList(); 
//--------------------------------------------------------------------------

//Array list ke pass aik mechanism hoota hai auto resizing jo hamare array ke length ko automatically increase karta rehta hai 
//Capacity property which tells number of items that can be stored under any collection
//This below is auto resizing mechanism EXP: 0 4 8 12 16 20 24 .....

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
            ArrayList MyList = new ArrayList(); 

            Console.WriteLine(MyList.Capacity); //Capacity = 0

            //ArrayList MyList = new ArrayList(10);  //capacity starts from 10 not 0 
            
            Console.WriteLine(MyList.Capacity); //Capacity = 4
            
            MyList.Add(10); 
            MyList.Add("Abdullah"); 
            MyList.Add("ali");
            MyList.Add(3.25); 

            Console.WriteLine(MyList.Capacity);

            MyList.Add(10); //jaise he 5th item de it will become double Capacity = 8
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);

            Console.WriteLine(MyList.Capacity);
            
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);

            Console.WriteLine(MyList.Capacity);

            Console.ReadLine();
        }
    }
}

//-----------------------------------------------
// How to print this on screen? -- use foreach loop
//-----------------------------------------------

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
            ArrayList MyList = new ArrayList(); 

            Console.WriteLine(MyList.Capacity);
            
            MyList.Add(10); 
            MyList.Add("Abdullah"); 
            MyList.Add("ali");
            MyList.Add(3.25);        

            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(10);
            MyList.Add(20);

            Console.Write(MyList.Capacity);
            Console.WriteLine();
            
            foreach (object obj  in MyList)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}

/*  
1.MyList.Insert(); //Store value in middle
2.MyList.Remove(); //Remove that Value Directly 
3.MyList.RemoveAt(); //Remove value by removing that index number
*/

//------------------------
// How to insert value
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
            ArrayList MyList = new ArrayList(); 
            
            MyList.Add(1);        
            MyList.Add(5);        
            MyList.Add(10);        
            MyList.Add(20);        
            MyList.Add(30);        
            MyList.Add(40);        
            MyList.Add(50);        
            MyList.Add(60);        
            MyList.Add(70);        
            MyList.Add(80);        
            MyList.Add(90);        
            MyList.Add(100);

            foreach (object obj in MyList)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();

            MyList.Insert(10, 95); // INDEX 10 PE STORE HOO JAYE GA 95 AUR 11TH INDEX PE 90 AJAYE GA 

            foreach (object obj in MyList)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
            Console.ReadLine();  
        }
    }
}

//--------------------------------------------------
// How to remove the value directly 
//--------------------------------------------------

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
            ArrayList MyList = new ArrayList();    
            
            MyList.Add(1);        
            MyList.Add(5);        
            MyList.Add(10);        
            MyList.Add(20);        
            MyList.Add(30);        
            MyList.Add(40);        
            MyList.Add(50);  //This value will be removed 
            MyList.Add(60);        
            MyList.Add(70);        
            MyList.Add(80);        
            MyList.Add(90);        
            MyList.Add(100);

            foreach (object obj in MyList)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();

            MyList.Remove(50); //Removes above Value 

            foreach (object obj in MyList)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

//---------------------------------------------
// How to remove value by removing index value
//---------------------------------------------

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
            ArrayList MyList = new ArrayList();   
            
            MyList.Add(1);        
            MyList.Add(5);        
            MyList.Add(10);        
            MyList.Add(20);        
            MyList.Add(30);        
            MyList.Add(40);        
            MyList.Add(50);        
            MyList.Add(60);        
            MyList.Add(70);        
            MyList.Add(80);        
            MyList.Add(90);  // This is removed        
            MyList.Add(100);

            foreach (object obj in MyList)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();

            MyList.RemoveAt(10); // Remove at index = 10 

            foreach (object obj in MyList)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}