//----------------------------
//  List<T> Generic Collection
//----------------------------

/*
1.There are several generic collection classes in the System.Collection.
   Generic namespace that includes the following:
   1. List
   2. Dictionary
   3. Stack -- Found in both
   4. Queue -- Found in both
  
2. The List<T> collection is the same as an ArrayList except that List<T> is a 
   generic collection whereas ArrayList is a non-generic collection.

3. A List class can be used to create a collection of any type. 
   For example, we can create a list of Integers, strings and even any complex types.
   List<T> class represents the list of objects which can be accessed by index.
 
4. list<int> list<string> list<float> list<char> -->Store homogeneous elements alehda alehta 
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
            List<int> ID = new List<int>();
            ID.Add(1);
            ID.Add(2);
            ID.Add(3);
            ID.Add(4);
            ID.Add(5);
            ID.Add(6);
            ID.Add(7);

            foreach (int item in ID)  
            {
                Console.WriteLine(item); //print data 
            }

            Console.WriteLine(ID.Capacity); // doubling 0 4 8 16 32

            List<string> Names = new List<string>();
            Names.Add("Ali");
            Names.Add("ABD");
            Names.Add("XYZ");
            Names.Add("ANAS");

            Console.WriteLine(ID.Capacity);

            List<decimal> Salary = new List<decimal>();
            Salary.Add(22500);
            Salary.Add(5500);
            Salary.Add(2200);
            Salary.Add(6200);
            
            Console.WriteLine(ID.Capacity);

            Console.ReadLine();
        }
    }
}

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
            List<int> ID = new List<int>();
            ID.Add(1);
            ID.Add(2);
            ID.Add(3);
            ID.Add(4);
            
            foreach (int item in ID)
            {
                Console.WriteLine(item);
            }

            List<string> Names = new List<string>();
            Names.Add("Ali");
            Names.Add("ABD");
            Names.Add("XYZ");
            Names.Add("ANAS");

            foreach (string item in Names)
            {
                Console.WriteLine(item);
            }

            List<decimal> Salary = new List<decimal>();
            Salary.Add(22500);
            Salary.Add(5500);
            Salary.Add(2200);
            Salary.Add(6200);

            foreach (decimal item in Salary)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

//------------------------------------------------------
//These two program below are Examples of complex Type 
//------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
     class Employee
    {
        public string name 
        {  
            set;
            get;
        }

        public int age
        {
            set;
            get;
        }

        public string designation
        {
            set;
            get;
        }
    }
}

//******************New Tab***************************

using program1; // We are using this 
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
            Employee Emp1 = new Employee()
            {
                name = "Ali",
                age = 22,
                designation = "Manager"
            };

            Employee Emp2 = new Employee()
            {
                name = "Abdullah",
                age = 25,
                designation = "Student"
            };

            List<Employee> EmpList = new List<Employee>();

            EmpList.Add(Emp1);
            EmpList.Add(Emp2);

            foreach (Employee emp in EmpList)
            {
                Console.WriteLine(emp.name + " " + emp.age + " " + emp.designation);
            }

            Console.ReadLine();
        }
    }
}

// We can access Data Index wise 

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

            Console.WriteLine(list[2]);  //Access using Index Numbers
        }
    }
}