//------------------------------------
// Concept of default constructor
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
     class program
    {
        public program()
        {
            Console.WriteLine("This is a default constructor");
        }
     
        static void Main(string[] args)
        {
            
             program p = new program(); // A default constructor is called when we make object of that class

            Console.ReadLine();

        }
    }
}

//------------------------------------
// Concept of parameterized constructor
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
        int EmpId, EmpAge;
        String EmpName;
        
        public Employee(int EmpID,String EmpName, int EmpAge)   // yeh aik construct sab objects ke liye kaam kare ga
        {
            this.EmpId = EmpID;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }

        public int getEmpID()
        {
            return this.EmpId;
        }

        public string getEmpName()
        {
            return this.EmpName;
        }

        public int getEmpAge()
        {
            return this.EmpAge;
        }

        static void Main(string[] args)
        {
            
            Employee Ali = new Employee(12,"Ali",19);
            Employee Abdullah = new Employee(13, "Abdullah",25);

            Console.WriteLine("Your ID is {0}", Abdullah.getEmpID());
            Console.WriteLine("Your name is {0}",Abdullah.getEmpName());
            Console.WriteLine("Your age is {0}", Abdullah.getEmpAge());

            Console.ReadLine();

        }
    }
}
