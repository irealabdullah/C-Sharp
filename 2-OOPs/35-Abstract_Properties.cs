//------------------
// Abstract Property
//------------------

/*
 1. Abstract means incomplete --> jiski koi implementation nahi hooti  
 2. This is duty of child class to implement an abstract memeber of parent class 
 3. We use abstract keyword
 4. Abstract property hamne class main banai hai tu class lazmi abstract hooni chahiye
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
    abstract class person //we will put common things here 
    {
        public abstract uint ID { get; set; } // iska set aur get ke body ke implementation child class dege 
        public abstract string Name { get; set; }

    }
    class student:person
    {
        uint StudentID;
        string studentName;  // yeh dono varaibles private hain -- hum set aur get use kar rahe iss main value initialize karwane ke liye
        public override uint ID
        {
            set
            {
                if(value == 0)
                {
                    Console.WriteLine("Enter correct value");
                }
                else
                {
                this.StudentID = value;
                }
            }
            get
            {
                return this.StudentID;
            }
        }
        public override string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value)==true)
                {
                    Console.WriteLine("Please Enter Name");
                }
                else
                {
                this.studentName = value;
                }
            }
            get
            {
                return this.studentName;
            }
        }
    }
    class program
    {

        static void Main(string[] args)
        {
            student Ali = new student();
            Ali.ID = 5; ///set
            Ali.Name = "";

            Console.WriteLine(Ali.ID); //get
            Console.WriteLine(Ali.Name);
            Console.ReadLine();

        }

    }
}
