using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAcquisition
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer p1 = new Producer("Ford", "America");
            Producer p2 = new Producer("Skoda", "Cehia");

            Customer c = new Customer("Popescu Ion", "popescu.ion@gmail.com", 0712345678);

            var listaProducator = new List<Producer>();
            listaProducator.Add(p1);
            listaProducator.Add(p1);

            Car c1 = new Car("Ford", 2017, 15000, 4);
            Car c2 = new Car("Skoda", 2015, 14000, 3);

            var listaMasini = new List<Car>();
            listaMasini.Add(c1);
            listaMasini.Add(c2);

            Order o1 = new Order(100, new DateTime(2018, 10, 28), c, c1);
            Order o2 = new Order(200, new DateTime(2018, 09, 10), c, c2);

            var listaOrder = new List<Order>();
            listaProducator.Add(p1);
            listaProducator.Add(p1);

            
            Console.ReadKey();
        }
    }
}
