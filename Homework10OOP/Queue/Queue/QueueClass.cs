using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue
{
    class QueueClass : IQueueClass
    {
        public QueueClass(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        private List<string> _queue = new List<string>();

        public void Enqueue(string name)
        {
            _queue.Add(name);
        }

        public string Dequeue()
        {
            //Pop() for Stack

            /*var len = _queue.Count();
            if (len > 0)
            {

                var str = _queue[len - 1];
                _queue.RemoveAt(len - 1);
                return str;
            }

            else
            {
                throw new Exception("Stack empty!");
            }*/

            var len = _queue.Count();
            if (len > 0)
            {

                var str = _queue[0];
                _queue.RemoveAt(0);
                return str;
            }

            else
            {
                throw new Exception("Queue empty!");
            }
        }
        public void Print()
        {
            Console.WriteLine($"\nThe names in the queue are: ");

            foreach (var nume in _queue)
            {
                Console.WriteLine(nume);
            }
        }
    }
}
