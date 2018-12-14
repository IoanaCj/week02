using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Hotel
{
    public class Rate
    {
        public Rate(decimal amount, string currency)//de ce folosesc constructor parametrizat
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t\t Price is {Amount} {Currency}");
        }

         public void UpdatePrice(decimal newPrice)
        {
            this.Amount = newPrice;
        }

    }
}
