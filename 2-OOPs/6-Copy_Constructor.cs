//------------------------------------
// Concept of Copy Constructor
//-------------------------------------

//In c#, Copy Constructor is a parameterized constructor which contains a parameter of same class type. The copy constructor in C# is useful whenever we want to initialize a new instance to the values of an existing instance.
//In simple words, we can say copy constructor is a constructor which copies a data of one object into another object.

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program
{
    class student
    {
        string name;
        int age;

        public student(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public student(student s)  //copy constructor
        {
            this.name = s.name;
            this.age = s.age;
        }

        public void getData()
        {
            Console.WriteLine("Your name is "+ name);
            Console.WriteLine("Your age is "+ age);
        }
         static void Main(string[] args)
        {
            student obj = new student("Ali",20); //ye value dosre object ke liye chahiye tu we use copy constructor
            obj.getData();
            student obj1 = new student(obj);
            obj1.getData();
            Console.ReadLine();

        }
    }
}

