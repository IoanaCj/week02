using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueueClass q = new QueueClass("Coada1");
            q.Enqueue("Dondanescu");
            q.Enqueue("Popescu");
            q.Enqueue("Averescu");
            q.Enqueue("Parpauta");
            q.Enqueue("Filipescu");
             

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            

            q.Print();

            Console.ReadKey();

        }
    }
}
