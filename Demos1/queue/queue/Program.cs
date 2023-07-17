using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //queue = First in first out
            Queue queue = new Queue();
            queue.Enqueue("viya");
            queue.Enqueue("kavi");
            queue.Enqueue("gai-3");
            queue.Enqueue("karthi");
            queue.Enqueue("gandhi");
            Console.WriteLine("number of items in queue are: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after removing:\t" + queue.Dequeue());
            Console.WriteLine("after removing:\t" + queue.Dequeue());
            Console.WriteLine("number of items in queue are: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek example: \t" + queue.Peek());
            Console.WriteLine("after Peek");
            Console.WriteLine("number of items in queue are: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Clear();
            Console.WriteLine("After clear number of items are:" + queue.Count);
            Console.ReadKey();
        }
    }

}
