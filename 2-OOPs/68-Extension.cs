//EXTENSION

/*
1. This concept allows you to inject some methods in a class without doing any modification, deriving in a class
2. in simple words suppose aik class hai jismain 5 methods hain. I want that uss class ko bina touch kiye main usmain kuch aur methods add karloon. jo extra methods add karoon ga usse extension kehte hain 

suppose we have class A and it contains 5 methods and we want to add extra 5 methods to Class A. we can use concept of inheritence and make Class B : Class A. 
All 5 methods from Class A will come into Class B and we add 5 extra methods to Class B 

If we use Inheritence then what is need of Extension??

Sometime we cannot use Inheritence concept to add methods in a class For example
1. If our Class A is sealed then we cannot inherit 
2. We cannot apply inheritence concept on struct as it is value type 
*/

// Suppose yeh below class ka source code mere pass nahi hai and jis company main main kaam karta hoon woh mujhe allow nahi karte that i do modification in this below class but still i want to do some modifications 
// I will use extension methods 
// First I will create new class and remember the class should be static 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
     class Program
    {
        public void func1()
        {
            Console.WriteLine("This is First Function");
        }

        public void func2() 
        {
            Console.WriteLine("This is Second Function");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.func1();
            p.func2();
            Console.ReadLine();
        }
    }
}

//--------------------------------------------
//MyStaticClass.cs 

// Remember we make static class when making extensions 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
     static class myStaticClass
    {
        public static void func3(this Program p) // Extension Declaration //this method belongs from above class
        {
            Console.WriteLine("This is 3RD Function..");
        }
    }
}
//--------------------------------------------
//Now I will create another class where I will call above methods 

//TestExtension.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
     class TestMethod
    {
        static void Main()
        {
            Program obj = new Program();
            obj.func1();
            obj.func2();
            obj.func3(); // Extension Method 
            Console.ReadLine();
        }
    }
}


//Part#2 

// ab mujhe program class ke method ko run nahi karna. I want to run TestExtension.cs main method so I will make some changes in setting 

//right click on namespace --> properties --> Start up object --> select main 


//Watch remaining Lecture 