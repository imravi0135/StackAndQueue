using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks and Queues");
            Console.WriteLine("My Queues Are :");
            Queue queue = new Queue();
            queue.Push(56);
            queue.Push(30);
            queue.Push(70);
            queue.Dequeue();
            queue.DisplayQueue();
            Console.ReadKey();
        }
    }
}
