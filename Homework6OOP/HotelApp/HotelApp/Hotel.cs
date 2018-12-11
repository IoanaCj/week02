using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Hotel
    {
        public Hotel(string name, string city, List<Room> listOfRooms)
        {
            this.Name = name;
            this.City = city;
            this.ListOfRooms = listOfRooms;
        }
        private string Name { get; }
        private string City { get; }
        public List<Room> ListOfRooms { get; }

        public Rate DailyRate = new Rate();

        public decimal GetPriceForNumberOfRooms(Room room, int numberOfRooms)
        {
            return numberOfRooms * room.DailyRate.Amount;
        }

        public string Print()
        {
            return $"The {Name} hotel from {City} has the price {DailyRate} per day per room";
        }
    }
}
