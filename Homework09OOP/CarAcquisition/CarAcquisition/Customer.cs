using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAcquisition
{
    class Customer : Entity, ICustomer
    {
        public Customer(string name, string email, int telephoneNumber)
        {
            this.Name = name;
            this.Email = email;
            this.TelephoneNumber = telephoneNumber;
        }
        public override string GetName()
        {
            return "CustomerName";
        }
        public string Name { get; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }

        public string BuyCars()
        {
            return "Buy the car";
        }
        public void PrintCustomer()
        {
            Console.WriteLine($" Customer name: {this.GetName()}, e-mail: {this.Email}, telephone: {this.TelephoneNumber} from {this.Address}");
        }
    }
}
