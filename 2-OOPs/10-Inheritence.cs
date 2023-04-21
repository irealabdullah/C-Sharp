
//--------------------------------------
// Inheritence In C#
//--------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE_CSHARP
{
    class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;

        public void show()
        {
            Console.WriteLine("This is a method of base class !!");
        }

    }

    class PermanentEmployees : Employees
    {

        public int permanentSalary;
        public int permanentHours;
    }

    class VisitingEmployee : Employees
    {
        public int visitingSalary;
        public int visitingHours;

    }


    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployees Abdullah = new PermanentEmployees();
            Abdullah.EmpId = 12;
            Abdullah.EmpName = "Abdullah";
            Abdullah.show();


            Console.WriteLine(Abdullah.EmpId);
            Console.WriteLine(Abdullah.EmpName);
            Console.ReadLine();
        }

    }
}

