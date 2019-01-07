using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    interface IQueueClass
    {
        void Enqueue(string name);
        string Dequeue();
        void Print();
    }
}
