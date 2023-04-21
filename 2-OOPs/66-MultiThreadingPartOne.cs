//----------------------------
// Multi Threading
//----------------------------

/*
1. Multi Tasking --> below is concept of Multi Tasking
2. OS --> PROCESS(Application) PROCESS(Application) PROCESS(Application)   
    * Operating system make diffrent processes 
    * In Task Manager we kill the process 
    * process main hamari application chal rahi hooti hai 
    * Application ka code kon execute karta hai ---> Thread 
    * Process Thread ka sahara leeta hai hamare code ko execute karne ke liye 
    * Application ka code Thread Execute karta hai aur --> and in our whole application there is only one single thread

3. Every application has a single thread by default to execute a program and that single thread is known as MAIN THREAD.Every application follows single threaded model. 
    
This is Single Thread Model concept. But we have very Big applications where we use Multi Threading concept
                   
                               -> Thread 1    
4. OS --> Process(Application) -> Thread 2
                               -> Thread 3
    
Now we have three threads -- Now our application can execute smoothly

5. we acheive multi tasking using threads
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
using System.Diagnostics;

using System.Threading; // to use thread we use this namespace

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread; //current thread ko t ke variable/object main store karwade ga 
            t.Name = "Main Thread"; //Set name of our thread
            Console.WriteLine("Your thread name is:" + Thread.CurrentThread.Name);
            Console.ReadLine();
        }
    }
}

//Concept of Multi-Threading:

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
            //above 3 Functions ko execute karne ke liye we have only one single thread as we know 

            program.func1(); //Main thread one by one in sab ko execute kare gi in order .This is responsibility of thread
            program.func2();
            program.func3();

            Console.ReadLine();
        }
    }
}

/*
 For example func2() main bohat zaida complex coding howi hai jo ke database se data fetch karwa ke app ko dee rahi hai means it is taking time in execution time: 10-15 seconds -- aur sirf single thread use hoo rahi hai That is why we need to create Multiple Threads 
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
                if(i==25)
                {
                    Console.WriteLine("Thread is going to sleep for 8 seconds");
                    Thread.Sleep(8000); // means our thread will go to sleep for 8 seconds when i = 25
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
            program.func1();
            program.func2(); //After 8 seconds func3 code will execute
            program.func3(); 

            Console.ReadLine();
        }
    }
}

// so now func3 will run after 8 seconds 
// we will create multiple threads so that func3 executes on time 

// we make thread 1 and pass it func1
// we make thread 2 and pass it func2
// we make thread 3 and pass it func3

// code will run simultanesouly
// Threads are executed by the operating system using time-sharing. (har aik function ko equally priority deeta hai)
// Threads are executed simultaneously.

/*
Thread 1 --> func1() 2 SECONDS
Thread 2 --> func2() 2 SECONDS
Thread 3 --> func3() 2 SECONDS
operating system decide kis function ko kitna time dena hai
*/
