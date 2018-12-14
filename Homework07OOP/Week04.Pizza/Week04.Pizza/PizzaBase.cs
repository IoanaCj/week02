using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Pizza
{
    class PizzaBase
    {
        public PizzaBase(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public decimal GetPrice()
        {
            if (this.Name == "Italian")
            {
                return Cost * Convert.ToDecimal(1.5);
            }
            return this.Cost;
        }

        public void Print()
        {
            Console.WriteLine($"\t {Name} pizza dough is {Cost}");
        }
    }
}
