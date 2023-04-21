//----------------
// Directory Info
//----------------

/*
 1. Used to Create,delete and move directory/folder 
 2. we use DirectoryInfo Class Functionality to work with folders or directories
 3. To use DirectoryInfo we need to import System.IO
 4. DirectoryInfo have same properties like Fileinfo but DirectoryInfo class operates
    on directories not files
 5. DirectoryInfo class doesnot have static methods 

    Create				This method is used to create the new directory.
    CreateSubdirectory	This method is used to create a subdirectory or 										subdirectories on the specified path.
    MoveTo				Moves a DirectoryInfo instance and its contents to a 									new path.
    Delete				Deletes this instance of a DirectoryInfo, specifying 									whether to delete subdirectories and files.
    GetDirectories		This method is used to get the sub directories in the 									given directory path.
    GetFiles			The GetFiles method is used to get the files in the 									specified folder.

    Useful Properties Of Directory Info:
    Name   --> Name of Folder
    FullName --> Full path of Folder
    LastAccessTime --> last time access to Folder
    CreationTime --> last time Folder created
    Attributes --> tell you that it is directory
    Parent --> tell you that folder parent is Desktop 
    Root --> Main Directory C:\
    LastWriteTime --> 
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
            string path = "D:\\My Directory";    //Verbatiam Literal
            DirectoryInfo dir = new DirectoryInfo(path); //we can add path directly
            dir.Create(); //dir my directory ko represent kar raha hai 
            Console.WriteLine("Directory Created");
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.LastWriteTime);
            Console.ReadLine();
        }
    }
}

//See remaining lecture of File Handling