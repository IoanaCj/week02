using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Pizza
{
    class PizzaGen
    {
        public  PizzaGen(string name, PizzaBase dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<PizzaTopping>();
        }
        public string Name { get; set; }
        public List<PizzaTopping> Toppings { get; set; }
        public PizzaBase Dough { get; set; }

        public void AddTopping(PizzaTopping pizzaTopping)
        {
            Toppings.Add(pizzaTopping);
        }

        public decimal CalculateTotalCost()
        {
            decimal toppingCost = 0;

            foreach (var topping in Toppings)
            {
                toppingCost += topping.Cost;
            }
            return toppingCost + Dough.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine($"Pizza {Name}");
            this.Dough.Print();
            Console.WriteLine("Toppings:");
            foreach (var tpg in Toppings)
            {
                tpg.Print();
            }


            Console.WriteLine($"Total Cost of pizza:{CalculateTotalCost()}");




        }
    }
}
