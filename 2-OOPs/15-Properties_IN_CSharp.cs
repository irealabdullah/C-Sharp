//------------------------------------
// Properties in C#
//------------------------------------

//Important point:-
//Properties are used for Encapsulation 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Encapsulation
{
    class student
    {
        private int StudentID;
        private string name;
        private string FatherName;

        public int StdID  //Property syntax
        {
            set //Acessor
            {
                this.StudentID = value;
            }

            get //Getter
            {
                return this.StudentID;
            }
            
        }

        public string StdName
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            student Ali = new student();
            Ali.StdID = 20;
            Ali.StdName = "Ali";
            Console.WriteLine(Ali.StdID);
            Console.WriteLine(Ali.StdName);
            Console.ReadLine();

        }

    }
}

/*----------------------------------------------------------------------

Types Of Properties In C#:
1.	Read / write properties --> GET AND SET BLOCK 
2.	Read only properties  --> Only Get Block  //More used
3.	Write only properties --> Only Set block  //Less used 
4.	Auto implemented properties --> prop  double tab
*/


//----------------------------------------------------------------------
// Auto implemented properties --> prop  double tab
//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Encapsulation
{
    class student
    {
        public string Firstname { get; private set; }
        public string LastName { get; private set; }

        public student(string fname,string lname)
        {
            this.Firstname = fname;
            this.LastName = lname;
        }
    }

    // jab ham set ko private kar dete tab uss class ka constructor/member he usko value de sakta hai 
    class Program

    {
        static void Main(string[] args)
        {
          student s = new student("Abdullah","Tariq");
           // s.Firstname = "Ali";
           // s.LastName = "Khan";
            Console.WriteLine(s.Firstname + " " + s.LastName);
            Console.ReadLine();
        }

    }
}
