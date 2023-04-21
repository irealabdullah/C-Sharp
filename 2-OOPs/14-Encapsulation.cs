//------------------------------------
// Encapsulation
//------------------------------------

//Encapsulation is a concept jis main Data(Variables) + Data(Methods or Properties) are wrap together in single unit

// can Age be negative? No --> That is why we hide our data(variable) by writing Private keyword with variables

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Encapsulation
{
   class person
   {
       public string name;
       public int age;
   }



   class Program
   {
       static void Main(string[] args)
       {
           person p = new person();
           p.name = "Abdullah";
           p.age = -25;
           Console.WriteLine(p.name);
           Console.WriteLine(p.age);
           Console.ReadLine();

       }

   }
}

//as we can see above age cannot be negative that is why we use concept of encapsulation
//-->Hide variable by using private keyword and make method and use if else in methods so that our data is not negative
// this is the use of ENCAPSULATION


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Encapsulation
{
    class person
    {
        private string name;  
        private int age;

        public void setName(string name)
        {
            if(string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.name = name;
            }
            
        }

        public void setAge(int age)
        {
            if(age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Age cannot be less than 0");
            }
            
        }



        public void GetName()
        {
            if (string.IsNullOrEmpty(this.name) == true) // agar khali hai tu kuch bhi nah karo warna name display karwa doo
            {
               
            }
            else
            {
                Console.WriteLine("Your Name is " + this.name);
            }
           
        }

        public void getAge()
        {
            if(age>0)
            {
                Console.WriteLine("Your Age is " + this.age);
            }
            else
            {
                
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.setName("Ali")  ;
            p.setAge(20) ;

            p.GetName();
            p.getAge();
            Console.ReadLine();

        }

    }
}


