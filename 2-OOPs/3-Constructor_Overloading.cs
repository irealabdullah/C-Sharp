//------------------------------------
// Concept of Constructor Overloading
//-------------------------------------


using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program
{
     class Employee   
    {
        public Employee()
        {
            Console.WriteLine("1. This is a default Constructor");

        }

        public Employee(int x)
        {
            Console.WriteLine("2. This is a Parameterized Constructor " + x);
        }

        public Employee(int y,int x)
        {
            Console.WriteLine("3. This is a Parameterized Constructor " + x +" "+ y);

        }

        public Employee(string x)
        {
            Console.WriteLine("4. This is a Parameterized Constructor " + x );

        }

        static void Main(string[] args)
        {
            Employee E = new Employee();
            Employee F = new Employee(10);
            Employee G = new Employee(10, 15);
            Employee H = new Employee("Abdullah");
            Console.ReadLine();
        }
    }
}

