using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Room
    {
        public string Name { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }

        public Rate DailyRate = new Rate();
            public void AddRate(int Amount, string Currency)
        {
            this.DailyRate.Amount = Amount;
            this.DailyRate.Currency = Currency;

        }

        public string GetPriceForDays(int numberOfDays)
        {
            return $"The price is {DailyRate.Amount * numberOfDays}{DailyRate.Currency} for {numberOfDays} days";
        }

        public string Print()
        {
            return $"In the {Name} hotel, {Adults} adults and {Children} children are allowed per room check-in, for the price of {rate.Amount}{rate.Currency} per day";
        }
    }
}

