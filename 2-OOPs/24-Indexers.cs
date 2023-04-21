//-----------
// INDEXERS 
//-----------

/*
 1. Indexers ke through hum kisi bhi type ka Data apne Array main store karwaye ge 
 2. In set and get we encapsulate only single variable but here we use INDEXERS and set&get millions of record
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Employee
    {
        private int[] Age = new int[3];
    }
    class Program  // yeh upper Employee Ke class main jo Array hai who iss program class ko access nahi kar sakte directly as we used PRIVATE
    {               // we will make indexer that data we send is valid or not 
        static void Main(string[] args)
        {

        }
    }
}

/*if we want to encapsulate we use list Exp:List/collection
kis qism ka data jaye ga list main we use indexers
Indexers ke through hum kisi bhi type ka data apne array main store karwa sakte hain
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Employee
    {
        private int[] age = new int[3];
        public int this[int index]
        {
            set 
            {
                if (index>=0 && index<age.Length)
                {
                
                if (value>0)
                {
                age[index] = value; 
                }
                else
                {
                    Console.WriteLine("Invalid Age");
                }

                }
                else
                {
                    Console.WriteLine("Invalid Index");
                }
            }
            get 
            {
                return age[index];
            }
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Employee Ali = new Employee();
            Ali[4] = 5;
            Console.WriteLine("Your are "+Ali[0] + " year old");
            Console.ReadLine();
        }
    }
}

/* Two things to keep in mind:
1.When user put values --> tu array ke size se zaida nahi hoone chahiye
2.Age kabhi negative nahi hoone chahiye 
upper dono cheezoon ke liye we use if/else condition 
*/

//----------------------
// INDEXER OVERLOADING:  --> RARELY USED IN C#
//----------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXERS
{
    class Employee
    {
        private int[] Age = new int[3];

        public int this[int index]
        {
            set 
            {
                if(index >= 0 && index < Age.Length)
                {

                if(value > 0)
                {
                Age[index] = value; 
                }
                else
                {
                    Console.WriteLine("Value is invalid !!");
                }
                }
                else
                {
                    Console.WriteLine("Invalid index !!");
                }
            }
            get 
            { 
                return Age[index];
            }
            
        }

        public int this[int index, int i]
        {
            set 
            {
                Age[index] = value + i;
            }
            get 
            {
                return Age[index];
            }
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[0, 1] = 5;
            //emp[2] = 5;
            Console.WriteLine(emp[0]);
            Console.ReadLine();
        }
    }
}
