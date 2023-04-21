//---------------
// File Handling 
//---------------

/*
 1. Ram(Memory Erase) vs HardDisk(Permenant memory)
 2. Jitne bhi application hum run karte hain unko execution dene ka kaam RAM ka hoota hai. 
 3. C# PROGRAM CONTAINS (VARIABLES METHODS ETC.) [IT IS ON OUR HARDDISK]  || WHEN WE RUN IT IT IS EXECUTED IN RAM  
 4. C# Program ke variables ko memory allocate tab hooti hain jab woh RAM main ajata hai aur jab execution khatam hoo jati hai tab Program RAM se remove hoo jata hai 
    jaise he hamain output milta hai --> execution stops and removed from RAM 

 5. Now if we want to store output of our program inside Text File/Notepad and that file is on our Harddisk 
   
 6. The concept of FILE HANDLING is that we store output of our program in a Notepad File/or any other file on our Harddisk
 
 7. File have two things 
        File Name => Abc.txt
        File Directory Path => C:\Program\Abdullah\Abc.txt 
 8. We mostly do file handiling with these files [text .txt, Microsost word .doxc WordPad .rtf] etc.
 9. The concept of FILE HANDLING allows to store / retrive data on permanent storage 

 10. When a file is opened for reading or writing, it becomes a stream.
     The stream is basically the sequence of bytes passing through the communication path. 
     There are two main streams: the input stream and the output stream. 
     The input stream is used for reading data from file (read operation) and the output stream is used for writing into the file (write operation).

 11. The .Net framework provides a few basic classes for creating, reading and writing to files on the
     secondary storage and for retrieving file system information. They are located in the System.IO namespace and used both in desktop applications(winform) and the web applications(asp.net/asp.net MVC) 
     C# IS CONNECTED WITH .NET FRAMEWORK
 
 12. Classes used in File Handling in c#
       1) FileStream
       2) BinaryReader
       3) BinaryWriter
       4) StreamReader
       5) StreamWriter
       6) StringReader
       7) StringWriter
       8) DirectoryInfo
       9) FileInfo

    Note:
    These all classes are present in System.IO namespace.
    This namespace is used for performing operations with files.
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
using System.IO; // we use this namespace 

namespace Myproject
{
    class program
    {
        
        static void Main(string[] args)
        {
          
        }
    }
}