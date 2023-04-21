//-----------
// Structure 
//-----------

/*
 1. Student ka Data like (NAME, AGE, ROLLNO, GENDER) IN SABKO WE SAVE IN A CLASS/ STRUCTURE. In sab properties ko ham aik yaa aik se zaida object/students ko dee sakte hain asad/ali...
 2. In sab variables ke copy sab objects ke pass alehda alehda jaye ge 
 3. Strucrue are Value type and stored in stack and class is Refrence Type are stored in heap
 4. we use classes over struct as class data is stored in heap because heap size is big than stack 
 5. For Representing small amount of data we use structure like colour, rectangle etc.
 6. new key word is compulsory for class but not cumpulsory for structure
 7. Struct main we cannot make default constructor
 8. Class support inheritence and structure donot support inheritence
 9. Class can implement interfaces as well as structure
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Myproject
{
    struct program
    {
        public void func1()
        {
            Console.WriteLine("Hello pakistan");
        }
        static void Main(string[] args)
        {
            program call = new program();
            call.func1();
            Console.Read();
        }
    }
}

//New keyword is not cumpulsory for structure and we can initialize value 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    struct program
    {
        int a;
        
        public void func1()
        {
            Console.WriteLine("Hello pakistan" + a);
        }

        static void Main(string[] args)
        {
            program p;     // see no need to use "new" keyword
            p.a = 20; //Yeh pehle likhna zaroori hai before func1();
            p.func1();
            Console.Read();
        }
    }
}

//Struct cannot contain default constructor but we can make parameterized constructor