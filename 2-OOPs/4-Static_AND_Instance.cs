//------------------------------------
// Concept of Static and Instance member
//-------------------------------------

/*
1. separate copy send to every object --> Instance variable/Non Static variable (Copy share)
2. Use with Every Object --> Static Variable (No separate copy will be shared) 

Exp Roll no sabka different hoota
but school name sabka same hoota 

Instance --> we make object
Static --> Class name
*/


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
        public int rollno;   // fresh copy is send to every object of class
        public string FirstName; //we used public so that we can access it other class
        public string LastName; // if we dont use public then it is private by default and we cannot access in other class
         // These are instance variable without the word "Static"
       
        public static string Schoolname = "Beconhouse School System";  //isko hum class ke name ke sath use karain ge as we use the word static
        public static int fees= 25000;

        public void printFullname()  //instance method
        {
            string fullname = this.FirstName + this.LastName;
            Console.WriteLine("Your name is " + fullname);
        }

        public static int getfees()
        {
            return fees;
        }
    }

    class program   
    {
      
        static void Main(string[] args)
        {
          student Ali = new student();
            Ali.rollno = 10;
            Ali.FirstName = "Ali ";
            Ali.LastName = "Tariq";
            Ali.printFullname();
            Console.WriteLine(student.Schoolname);

            Console.WriteLine("-------------------");
            // inka apus main koi link nahi

            student Abdullah = new student();
            Console.WriteLine(Abdullah.rollno = 11);
            Console.WriteLine(Abdullah.FirstName = "Abdullah ");
            Console.WriteLine(Abdullah.LastName = "Tariq");
            Abdullah.printFullname();
            Console.WriteLine(student.Schoolname);
            Console.WriteLine(student.getfees());

            Console.ReadLine();
        }
    }
}

// now we make a static variable and static is something that doesnot change such as their school name 

// Important Note --> static method main we can only use static variable
//                    static method main we cannot use INSTANCE variable 

// Example:-
public int rollno;
public static int getfees()
    {
        Console.Readline(rollno);  // ERROR DEGA KYUNKE WE CANNOT ACCESS INSTANCE MEMEBERS IN STATIC METHOD
        return fees;
    }

// instance method main main static variable aur instance variable dono use kar sakte hain 

public void printFullname()  //instance method
{
    string fullname = this.FirstName + this.LastName;
    Console.WriteLine("Your name is " + fullname);
    Console.WriteLine(schoolname);
}

// INstance variable ke fresh copy jaye ge to every object separately  int rollno, string firstname, string lastname sab ke pass alehda jaye ge
// but 
// static member ke aik he copy sab objects use karain ge  exp schoolname to ali and abdullah 