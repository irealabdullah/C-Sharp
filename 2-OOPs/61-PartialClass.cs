//--------------
//Partial Class
//--------------

// Partial Class is used using partial Keyword 
// Partial means IN PARTS
// We use partial keyword when we have to use one class in diffrent tabs  (aik he class ke 2 parts)
// Classes in different tabs of visual studio and when we make object of a class, classes combine and gives result
// we use this concept(Partial class) with interfaces and struct 
// we use Partial class when code contains so many lines to manage 

// Steps to add a class:
// Right Click on Package-> Add --> Class 

// Steps to make implementation of Setter And Getter:
// right click on variable --> quick actions and refactorings.. --> encapsulate fields 


//------------
// Student.cs
//------------

// we are making a class for a student 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   public class Student
   {
      private string _firstname;
      private string _lastname;

      public string Firstname
      {
         set
         {
            _firstname = value;
         }
         get
         {
            return _firstname;
         }
      }
      
      public string Lastname
      {
         set
         {
            _lastname = value;
         }

         get
         {
            return Lastname;
         }
      }

      public string getcompletename()
         {
            return _firstname + " " + _lastname;
         }       
   }
} 

//----------------------------------------------
// Now we divide this class into different tabs 
//----------------------------------------------

// StudentPartial1.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
     public partial class StudentPartial //Class name is same as you can see in StudentPartail2.cs
    {
        private string _firstname;
        private string _lastname;

        public string Firstname
        {
            set
            {
                _firstname = value;
            }
            get
            {
                return _firstname;
            }
        }
        public string Lastname
        {
            set
            {
                _lastname = value;
            }

            get
            {
                return Lastname;
            }
        }
    }
}

// StudentPartial2.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
     public partial class StudentPartial //Class name is same as you can see in StudentPartail1.cs
    {
        public string getcompletename()
        {
            return _firstname + " " + _lastname;
        }
    }
}

// Main method class 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
     class Program
    {
        static void Main(string[] args)
        {
            StudentPartial obj = new StudentPartial();
            obj.Firstname= "Abdullah";
            obj.Lastname = "Tariq";

            Console.WriteLine(obj.getcompletename());

            Console.ReadLine();
        }
    }
}

/*
Advantages of Partial Keyword:

1.Multiple developers can work simultaneously with a single class in separate files.

2. When working on large projects, spreading a class over separate files allows programmers to
work on it simultaneously.

3. Visual Studio uses partial classes to separate, automatically generated system code from 
the developer’s code. For Example when you add a webform, two .CS files are generated.
   1. WebForm1.aspx.cs – Contains the developer code.
   2. WebForm1.aspx.designer.cs – Contains the system generated code. For example, declarations for the controls that you drag and drop on the webform
*/