//-----------------
// Generics Class 
//-----------------

//1. Genric class is a class jismain members har datatype par work perform kar sakain
//2. Generics replace these placeholders with some specific type at compile time

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Example
    {
        int box;
        
        public Example(int b)
        {
            this.box = b;
        }

        public int getbox()
        {
            return this.box;
        }
    }

    class program
    {       
        static void Main(string[] args)
        {
            Example obj = new Example(20);
            Console.WriteLine(obj.getbox());
            Console.ReadLine();
        }
    }
}

//------------------------
// Make your Class Generic
//------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Example<T>
    {
        T box;

        public Example(T b)
        {
            this.box = b;
        }

        public T getbox()
        {
            return this.box;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Example<int> obj = new Example<int>(20);
            Example<string> obj1 = new Example<string>("Abdullah");
            Example<double> obj2 = new Example< double >(20.98);
            Example<char> obj3 = new Example<char>('A');

            Console.WriteLine(obj.getbox());
            Console.WriteLine(obj1.getbox());
            Console.WriteLine(obj2.getbox());
            Console.WriteLine(obj3.getbox());

            Console.ReadLine();
        }
    }
}