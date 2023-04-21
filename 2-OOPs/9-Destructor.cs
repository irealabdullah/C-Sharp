//-----------------------------
//Concept of Destructor
//-----------------------------

/*
1. Immediately de-allocates memory of objects that are no longer required. 
2. Destructor is a special method which has the same name as the class but starts with the character ~ 

Following are the features of destructors:

1. Destructors cannot be overloaded (aik se zaida destructor nahi bana sakte) or inherited.
2. Destructors cannot be explicitly invoked (khud se call nahi karte).
3. Destructors cannot specify access modifiers and cannot take parameters.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESTRUCTORS
{

    class person
    {
        public string Name;
        public int Age;

        public person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }

        ~person()
        {
            Console.WriteLine("Destructor has been invoked !!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            person Ali = new person("Ali", 22);
            person Anas = new person("Anas", 23);
            Console.WriteLine(Ali.getName());
            Console.WriteLine(Ali.getAge());
            Console.WriteLine("--------------");
            Console.WriteLine(Anas.getName());
            Console.WriteLine(Anas.getAge());
            //Console.ReadLine();

        }
    }
}


// CTRL + F5 --> to see result