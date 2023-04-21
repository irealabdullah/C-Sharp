//----------
//  Queue 
//----------

/*
 1. Queue meaning: a line or sequence of people or vehicles.
    Another meaning: Qataar lagana.

 2. Enqueue->5->4->3->2->1->Dequeue      FIFI (First In - First Out)

 3. jo data first 1 pe hoo ga woh sabse pehle retrieve hoo ga  
 
 4. To insert we use Enqueue
 5. To Retrieve we use Dequeue
 
 6. Queue collection allows multiple null and duplicate values. 
 
 7. Properties And Methods Of Queue:
    Count		Returns the total count of elements in the Queue.
    Enqueue		Adds an item into the queue.
    Dequeue		Removes and returns an item from the beginning of the queue.
    Peek		Returns first item from the queue
    Contains	Checks whether an item is in the queue or not
    Clear		Removes all the items from the queue.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
            Queue data = new Queue(); //FIFO
            data.Enqueue(1);
            data.Enqueue("Abdullah");
            data.Enqueue(25);
            data.Enqueue("CEO");
            data.Enqueue(5.11);
            data.Enqueue("White");
            data.Enqueue("Student");

            foreach (object item in data)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();  
        }
    }
}