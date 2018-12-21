using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAcquisition
{
    class Store : Entity, IEntity, IStore
    {
        public Store(string name, Producer brand, Order carOrders)
        {
            this.Name = name;
            this.Brand = brand;
            this.CarOrders = carOrders;
        }
        public string Name { get; }
        public Producer Brand { get; set; }
        public Order CarOrders { get; set; }
        public override string GetName()
        {
            return "StoreName";
        }
        public string SellCars()
        {
            return "Sell the car";
        }
        public void PrintStore()
        {
            Console.WriteLine($" Store name: {this.GetName()} from {this.Address} is a dealer for {this.Brand} producer");
        }

    }
}
