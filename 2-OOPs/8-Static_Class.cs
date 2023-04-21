//------------------------
//concept of Static class 
//------------------------
/*
1. we cannot make object of static class
2. we cannot inherit 
3. we use static with class name 
4. static class main sirf static members, static methods, static constructor he hoo sakte hain not instance members 
5. We use static class jab humain data fix rakhna ho apni class main
*/

// Example 

//-----------------------------
//Concept of Static constructor
//-----------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    static class Employee
    {
        public static int EmpID;
        public static string EmpName;
        public static int EmpAge;

        static Employee()
        {
            EmpID = 10;
            EmpName = "Abdullah";
            EmpAge = 24;
        }

        public static void GetDetails()
        {
            Console.WriteLine(EmpID);
            Console.WriteLine(EmpName);
            Console.WriteLine(EmpAge);
        }

        static void Main(string[] args)
        {
            Employee.GetDetails();
            Console.ReadLine();
        }
    }
}
    
