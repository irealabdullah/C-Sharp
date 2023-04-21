
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
using System.Diagnostics;

using System.Threading;
namespace Myproject
{
    class program
    {
        public static void func1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func1:" + i);
            }
        }

        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func2:" + i);
                if (i == 25)
                {
                    Console.WriteLine("Thread is going to sleep for 8 seconds");
                    Thread.Sleep(8000); 
                }
            }
        }

        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func3:" + i);
            }
        }

        static void Main(string[] args)
        {
            // We created 3 Threads and passed functions //we have 4 threads 
            Thread t1 = new Thread(func1); //func1 refrence is passed to thread constructor
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            //to start thread we used this function
            t1.Start();
            t2.Start(); // agar ab delay a bhi jata hai tu baki functions run hoon ge // Concept of Multi Threading 
            t3.Start();             
            
            // Here multi Threading hoo rahi hai aur 
            Console.ReadLine();
        }
    }
}
/*
1. Threads are lightweight processes.
2. A thread is defined as the execution path of a program. 
3. Each thread defines a unique flow of control. 
4. If your application involves complicated and time consuming operations, then it is often helpful to set different execution paths or threads, with each thread performing a particular job.

5. In C#, the System.Threading.Thread class is used for working with threads. 
6. It allows creating and accessing individual threads in a multithreaded application. 
7. The first thread to be executed in a process is called the main thread.
8. When a C# program starts execution, the main thread is automatically created. 
9. The threads created using the Thread class are called the child threads of the main thread. 
10. You can access a thread using the CurrentThread property of the Thread class.

Let’s understand this concept with a very basic example. Everyone has used Microsoft Word. It takes input from the user and displays it on the screen in one thread while it continues to check spelling and grammatical mistakes in another thread and at the same time another thread saves the document automatically at regular intervals
*/