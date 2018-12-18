using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Animal()
        {

        }
        public void Print()
        {
            Console.WriteLine($"Animal Name: {Name} , age: {Age}, gender : {Gender}");
        }
    }
}
