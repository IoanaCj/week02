using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Pizza
{
    class PizzaTopping
    {
        public PizzaTopping(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }
        public int Cost { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t {Name} topping is {Cost}");
        }
    }
}
