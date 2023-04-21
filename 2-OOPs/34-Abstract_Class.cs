// ----------------
// Abstraction Class
// ----------------

/*
 1. person main student aur teacher dono ate hain
 2. jo cheezain student aur teacher main common hain we will put in person --> abstract class
 3. when we will inherit from person class common things will come in student class and teacher class
 4. yaa tu student ka object bane ga yaa tu teacher ka object bane ga 
 5. person ka object nahi bane ga so we will call it abstract class --> This is concept of abstract class 
 6. Abstract class ka object hum nahi bana sakte (cannot be instantiated)--> abstract class ko inherit karwa kar Child class ka object banaye ge 
 7. Abstract method ko body kon dee ga ? --> jo is body ke child class hoo ge 
 8. Hamari class main yaa abstract method hoo sakta hai ya nahi hoo sakta hai
    --lekin agar abstract method hai tu we will make our class abstract
 9. Abstract class main sare members abstract hoo bhi sakte hain aur nahi bhi hoo sakte
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
    abstract class person  //cannot make object of this class
    {
        public abstract void show(); // abstract method
    }

    class student : Person
    { 

    }
    
    class teacher : Person
    {

    }

    class program 
    {
        static void Main(string[] args)
        {
            
        }
    }
}

/*
EXAMPLES:
1. Shapes --> rectangle,square,cuboid
2. Person --> student, teacher 
3. Subjects --> English, urdu, maths, science
4. Laptop --> Hp,Hp pavillion,hp home, hp slim
5. Water --> Aquafina, Evian, Nestle
6. Pen --> Dollar, Dollar red , Dollar pointer
*/

// -----------------------------------------------------

/*
1. Abstract koi bhi idea hoo sakta hai ya koi bhi concept hoo sakta hai jiska koi object nahi hoota
2. Abstract method ka koi aik meaning nahi hai kyunke student aur teacher issko apne hisaab se implementation dee rahe hain 
3. Abstract is done when we need to inherit from a certain class 
4. Abstract class ko we can only use as a parent class
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
    abstract class person
    {
        public string Firstname;
        public string Lastname;
        public int age;
        public string Contact;

        public abstract void printDetails(); //isko body child class dain ge with keyword "override" 
    }

    class student : person
    {
        public int RollNo;
        public int Fees;

        public override void printDetails()
        {
            string name = this.Firstname + " " + this.Lastname;
            Console.WriteLine("Student Roll No: {0}",this.RollNo);
            Console.WriteLine("Student Name: {0}",name);
            Console.WriteLine("Student Contact: {0}",this.Contact);
            Console.WriteLine("Student Age: {0}",this.age);
            Console.WriteLine("Student Fees: {0}",this.Fees);
        }
    }

    class teacher : person
    {
        public String Qualification;
        public int salary;

        public override void printDetails()
        {
            string name = this.Firstname + " " + this.Lastname;
            Console.WriteLine("Teacher name: {0}",name );
            Console.WriteLine("Teacher age: {0}", this.age);
            Console.WriteLine("Teacher Contact: {0}", this.Contact);
            Console.WriteLine("Teacher  Qualification: {0}", this.Qualification);
            Console.WriteLine("Teacher Salary: {0}", this.salary);
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            student Ali = new student();
            Ali.RollNo = 32;
            Ali.Firstname = "Ali";
            Ali.Lastname = "Butt";
            Ali.age = 20;
            Ali.Contact = "03045600500";
            Ali.Fees = 32500;

            Ali.printDetails();

            Console.WriteLine("-------------------");

            teacher Basit = new teacher();
            Basit.Firstname = "Basit";
            Basit.Lastname = "Sattar";
            Basit.age = 38;
            Basit.Contact = "03006589565";
            Basit.salary = 98000;
            Basit.Qualification = "Computer Science FROM UK";

            Basit.printDetails();
            Console.ReadLine();
        }
    }
}

// we also use property method
// we can also use static variable inside abstract class
// abstract class can have constructor and destructor