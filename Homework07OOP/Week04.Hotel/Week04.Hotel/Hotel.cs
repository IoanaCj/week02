using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Hotel
{
    class Hotel
    {
        public Hotel(string name, string city, int stars, List<Room> rooms)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.Rooms = rooms;
        }
        public string Name { get; set; }
        public string City { get; set; }
        public int Stars { get; set; }
        public List<Room> Rooms { get; set; } 
        
        public void Print()
        {
            Console.WriteLine($"\t Hotel: {Name}");
            Console.WriteLine($"\t\t From {City} with {Stars}");
            foreach(var room in Rooms)
            {
                room.Print();//ca sa stiu cate camere are hotelul?
            }
        }
        
        public decimal GetPriceForAllRooms() // pretul total pe toate camerele hotelului
        {
            decimal x = 0;
            foreach( var room in Rooms)
            {
                x = x + room.Rate.Amount;
            }
            return x;
        }

        public void AddRoom(Room r)
        {
            this.Rooms.Add(r);
        }
        public void DeleteRoom(Room r)
        {
            this.Rooms.Remove(r);
        }

      
    }
}
