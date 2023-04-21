//---------------------------------
// Understang concept of value type 
//---------------------------------

// in struct ---> we use ---> value type ---> objects save in  stack 

//stack jaldi fill hoo jata and error deta stack overflow 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   struct student
    {
       public int salary;
       public int age;
    }

   internal class Program
   {
       static void Main(string[] args)
       {
           student s,s1,s2 = new student(); //three objects will be created s, s1, s2
           s.age = 25;
           s.salary = 23000;
           s1 = s;
           s2= s;

           s.age = 26; // s1 and s2 blocks will not be affected sirf yahi change hoga
           //s1 aur s2 main explicitly change karna hooga

           Console.WriteLine(s1.age);
           Console.WriteLine(s2.age);
           Console.ReadLine();
       }
   }
}

//------------------------------------
// Understang concept of Refrence type 
//------------------------------------

// in class ---> we use ---> refrence type ---> heap 
// refrence store hoota in stack and object stores in heap 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   class student
   {
       public int salary;
       public int age;
   }

   internal class Program
   {
       static void Main(string[] args)
       {
           student s = new student();
           s.age = 20;
           s.salary = 2000;
           student s1 = s;
           student s2 = s;

           s.age = 40;

           Console.WriteLine(s.age);
           Console.WriteLine(s1.age);
           Console.WriteLine(s2.age);

           Console.ReadLine();

           // sab ke values change hoo chuki hoon ge ]

       }
   }
}
