//------------------------------------------------------
// DIFFERENCE BETWEEN GENERIC AND NON-GENERIC COLLECTION 
//------------------------------------------------------

/*
1. ARRAY:  
    int[] arr = new int[3]; -> If store more than size -> Exeption: IndexOutOfRangeException

    Type Safe
    Fixed Length

NON-GENERIC COLLECTION:
    ArrayList al = new ArrayList(3);
    al.Add(object value);

    Not Type Safe
    Variable Length (Auto-Resizing)

2. suppose I want to create a collection which will only have integer elements.
   I don’t know how many integer elements will be stored in the collection.

THEN GENERIC COLLECTIONS COMES INTO ACTION

3. Generic Collections:
    Are Type Safe.
    Variable length (Auto Resizing)
 
4. Convert: Value type (int,float,char,double) into Refrence Type (object) ---> (called Boxing) [in non-generic collection]
5. Convert: Refrence Type (object) into value type (int,float,char,double) --------> (called unboxing) 

6. Generic collection performance ke lehaaz se zaida acha hai kyunke ismain type conversion nahi hooti 
 
7. Non Generic --> Not Type Safe
   Generic --> Type Safe
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
            List<int> data = new List<int>(); // generic
            data.Add(1);
            data.Add(2);
            data.Add(3);
            data.Add(4);
            data.Add(5);
            data.Add(6);
            data.Add(7);
            data.Add(8);
            data.Add(9);
            data.Add(10);  
        }
    }
}