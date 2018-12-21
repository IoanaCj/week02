using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAcquisition
{
    class Car
    {
        public Car(string model, int year, decimal price, int weeksOfDelivery)
        {
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.WeeksOfDelivery = weeksOfDelivery;
        }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int WeeksOfDelivery { get; set; }


        public void PrintCar()
        {
            Console.WriteLine($"The {this.Model} model, year: {this.Year} is {this.Price} EUR and has delivery term: {this.WeeksOfDelivery} weeks.");
        }
    }
}
