using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAcquisition
{
    class Producer : Entity
    {
        public override string GetName()
        {
            return "ProducerName";
        }

        public Producer(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public string Name { get; }
        public void PrintProducer()
        {
            Console.WriteLine($" Producer name: {this.GetName()} from {this.Address}");
        }
    }
}
