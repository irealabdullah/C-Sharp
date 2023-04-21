//------------------
//  INTERFACES
//------------------

/*
1.THREE WAYS TO ACHEIVE ABSTRACTION:
  1# ABSTRACT CLASS
  2# ABSTRACT METHODS
  3# INTERFACES
2. INTERFACE IS A CONTRACT BETWEEN ITSELF AND ANY CLASS 
3. CONTRACT SAYS KE ANY CLASS THAT INHERIT FROM INTERFACE WILL GIVE BODY TO INTERFACE METHODS,PROPERTIES AND EVENTS
4. INTERFACE MAIN JITNE BHI JEEZAIN HOOTI HAIN THEY ARE BY DEFAULT PUBLIC AND 100% ABSTRACT 
5. INTERFACE ONLY CONTAIN SIGNATURE/DECLARATION OF METHODS,PROPERTIES,INDEXERS & EVENTS
6. IN SIGNATURE KO LAZMI INKI CHILD CLASS COMPLETE KARE GE
7. CLASS <-- CLASS ==> CALLED INHERITENCE
8. INTERFACE <-- CLASS ==> CALLED IMPLEMENTATION

9. Main reason we use interface is that it is used in multiple inheritence
10. We dont use abstract keyword inside interfaces and we cannot make object of interface like abstract classes
11. Interfaces cannot have fields(variables chahe woh static hoo ya instance hoon)
12. ABDULLAH POINT --> ABSTRACT CLASS MAIN WE CAN MAKE FIELDS BUT NOT IN INTERFACES
13. HOW TO IMPLEMENT AN INTERFACE?
    A# INTERFACE KO WE INHERIT AND CHILD CLASS USKO BODY DEGE 
    B# IF ALL THE METHODS IN INTERFACE ARE NOT IMPLEMENTED/DECLARED IN THE CHILD CLASS --> COMPILER WILL NOT COMPILE 
    C# SIGNATURE SAME HOONA CHAHIYE INTERFACE KE ANDER METHODS KA AUR CHILD CLASS KE METHODS KA 
14. WE USE SHORTCUT FOR DECLARING BODY IN CHILD CLASS

                     --> Dog{ AnimalSound(){Console.WriteLine("Dog barks");}}   
15. IAnimalInterface--> Cat{AnimalSound(){Console.WriteLine("Cat Meows");}}
                     --> Lion{AnimalSound(){Console.WriteLine("Lion Roar");}}
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
    interface IEmployee
    {
        void show();        
    }

    class partTimeEmployees : IEmployee
    {
        public void show()
        {
            Console.WriteLine("Hello world");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
          partTimeEmployees obj = new partTimeEmployees();
          obj.show();
        }
    }
}



