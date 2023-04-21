//-----------------------------
// 1. Method Overriding
//-----------------------------

/*
Dynamic Or Runtime Polymorphism In C#:

C# provides techniques to implement Dynamic polymorphism. They are −
(a) Method Overriding 
Run time polymorphism is achieved by method overriding.
Method overriding allows us to have virtual and abstract methods in the base using derived classes with the same name and the same parameter.

Method ka name and signature same hoo ga parent class ka bhi aur child class ka bhi 
Method overiding ke concept main hum parent class ke fuction ko "virtual" banate hain aur child class ke function
ke sath override likhtain hain
aur jab hum parent class ka object bbanaye ge tu parent class ka method nahi call hoo ga balke child class ka hoo ga

Function ke defination aur signature same hai but
Function ke body main jo code hai uss ko implementation kehte hain woh 
different hai 
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
    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is a Parent Class");
        }
    }

    class child:parent
    {   
        public override void print()
        {
            Console.WriteLine("This is a Child Class");
        }
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            parent p = new child();
            p.print();
            Console.ReadLine();
        }

    }
}

/* 
virtual keyword means imaginary (gayab hoo jana)
overide keyword -->override karde ga 
*/

using System;
namespace AbstractionDemo
{
   class Shape
   {
     public virtual double area()
     {
         return 0;
     }
   }
   class Circle: Shape
   {
     private double radius;
     public Circle( double r)
     {
        radius = r;
     }
     public override double area ()
     {
        return (3.14*radius*radius);
     }
   }
   class Square: Shape
   {
     private double side;
     public Square( double s)
     {
        side = s;
     }
     public override double area ()
     {
        return (side*side);
     }
   }
    class Triangle: Shape
   {
     private double tbase;
     private double theight;
     public Triangle( double b, double h)
     {
        tbase = b;
        theight = h;
     }
     public override double area ()
     {
        return (0.5*tbase*theight);
     }
  }
   class Test
   {
     static void Main(string[] args)
     {
        Circle c = new Circle(2.5);
        Console.WriteLine("Area of Circle = {0}", c.area());
        Square s = new Square(5.5);
        Console.WriteLine("Area of Square = {0}", s.area());
        Triangle t = new Triangle(3.0, 5.0);
        Console.WriteLine("Area of Triangle = {0}", t.area());
     }
   }
}