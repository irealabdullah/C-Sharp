//---------------
// Sealed Method
//---------------

/*
Sealed Method overriding main he sirf use hoote hain 
Steps To Remember For Sealed Methods:
	Sealed method is always an override method of child class.
	We cannot again override the sealed method.
	Sealed method is only available with Method Overriding.
	Sealed keyword is not available with the method hiding.
	Sealed is used together with override method.
	We cannot make normal methods as sealed.
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
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("This is class A ...");
        }
    }
    class B: A
    {                                       // Sealed and override keyword aik sath use hoote hain
        public sealed override void show() // agar hum sealed ka keyword use karain tu iss method ko koi override nahi karsakta.
        {                        // as we can see below in class c error araha hai method main kyunke ab iss class B ke method ko override nahi kia jaa sakta 
            Console.WriteLine("This is a class B ...");
        }
    }

    class C : B  // CLASS C KO HUM NE INHERIT KARWAYA CLASS B SE AUR CLASS C KE METHOD KO HUMNE OVERRIDE KARWADIA 
    {
        public override void show() 
        {
           Console.WriteLine("This is a class C ...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            C obj = new C();
            obj.show();
            Console.ReadLine();
        }

    }
}
*/

//child class jo kisi parent class ko override kare ge wohi sealed class ho sakti hai