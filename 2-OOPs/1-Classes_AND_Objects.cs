/*
1. Class is a blueprint/Template EXP: Human
2. Object is an entity such as car, a table, student or a briefcase
3. Objects have methods(stop(), break(), fast()) and variables (company name, model, price, wheels, colour, mileage [properties/charateristics])
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
     class Student
    {
        int rollno;
        string name;
        int age;

        public void setrollno(int r)
        {
            this.rollno = r;
        }
        
        public int getrollno()
        {
            return this.rollno;
        }
        static void Main(string[] args)
        {
            Student Abdullah = new Student();
            Abdullah.setrollno(10);
            Console.WriteLine(Abdullah.getrollno());
            Console.ReadLine();
        }
    }
}

// ---------------------------------------------------------------------------

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Student
    {

        int rollno;
        string name;
        int age;

        public void setstudent(int r,string n,int a)
        {
            this.rollno = r;
            this.name = n;
            this.age = a;
        }
        
        //public int getrollno()
        //{
        //    return this.rollno;
        //}

        //public String getstudentname()
        //{
        //    return this.name;
        //}

        //public int getAge()
        //{
        //    return this.age;
        //}

        public void getstudentdetails()
        {
            Console.WriteLine(this.rollno);
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }

        static void Main(string[] args)
        {
            Student Abdullah = new Student();
            Abdullah.setstudent(20519, "Abdullah", 25);
            //Console.WriteLine(Abdullah.getstudentname());
            //Console.WriteLine(Abdullah.getrollno());
            //Console.WriteLine(Abdullah.getAge());
            Abdullah.getstudentdetails();
            Console.ReadLine();
        }
    }
}

*/

// -----------------------------------------------------------------------------

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Program
{
    internal class Student
    {

        int rollno;
        string name;
        int age;

        public void setstudent(int rollno,string name,int age)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
        }
        public void getstudent()
        {
            Console.WriteLine(this.rollno);
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            
            Console.Write("Enter Age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Roll No: ");
            int Rollno = int.Parse(Console.ReadLine());

            Student Abdullah = new Student();
            Abdullah.setstudent(Rollno,Name,Age);
            
            Abdullah.getstudent();  
            Console.ReadLine();
        }
    }
}
