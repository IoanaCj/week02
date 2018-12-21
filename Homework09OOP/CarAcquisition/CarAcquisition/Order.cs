using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAcquisition
{
    class Order
    {
        public Order(int numberOfOrder, DateTime dateOfOrder, Customer customer, Car car)
        {
            this.NumberOfOrder = numberOfOrder;
            this.DateOfOrder = dateOfOrder;
            this.Customer = customer;
            this.Car = car;

        }
        public int NumberOfOrder { get; set; }
        public DateTime DateOfOrder { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public void PrintOrder()
        {
            Console.WriteLine($" Order no.{this.NumberOfOrder}/{this.DateOfOrder}");
            Console.WriteLine($" Customer: {this.Customer.GetName()}, {this.Customer.Email}, {this.Customer.TelephoneNumber}");
            Console.WriteLine($" Car: {this.Car.Model}, {this.Car.Year}, {this.Car.Price}, {this.Car.WeeksOfDelivery}");
        }
    }
}
