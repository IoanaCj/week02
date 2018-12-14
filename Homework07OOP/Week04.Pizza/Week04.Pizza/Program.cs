using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase p1 = new PizzaBase("Regular", 10);
            PizzaBase p2 = new PizzaBase("Thick", 20);
            PizzaBase p3 = new PizzaBase("Italian", 30);

            PizzaTopping pt1 = new PizzaTopping("Cheese",2);

            PizzaTopping pt2 = new PizzaTopping("Meat", 5);
            PizzaTopping pt3 = new PizzaTopping("Vegetable", 3);

            PizzaGen myFavouritePizza = new PizzaGen("Hawai", p1);
            myFavouritePizza.AddTopping(pt1);
            myFavouritePizza.AddTopping(pt2);

            myFavouritePizza.Print();
            Console.ReadKey();

        }
    }
}
