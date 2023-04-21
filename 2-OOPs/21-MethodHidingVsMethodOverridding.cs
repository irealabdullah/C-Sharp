//-----------------------------
// Method Hiding
//-----------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
   class parent
   {
       public void show()
       {
           Console.WriteLine("This is a parent class");
       }
   }

   class child : parent
   {
       public new void show()
       {
          // base.show();
           Console.WriteLine("This is a child class");
       }
   }

   class Program
   {
       static void Main(string[] args)
       {
           parent p = new child();
           p.show();
           Console.ReadLine();

       }

   }
}

-----------------------------
Method  Overriding
-----------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
   class parent
   {
       public virtual void show()
       {
           Console.WriteLine("This is a parent class");
       }
   }

   class child : parent
   {
       public override void show()
       {

           Console.WriteLine("This is a child class");
       }
   }

   class Program
   {
       static void Main(string[] args)
       {
           parent p = new child();
           p.show();
           Console.ReadLine();

       }

   }
}
