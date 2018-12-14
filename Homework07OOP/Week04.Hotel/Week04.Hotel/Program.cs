using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Hotel
{
    class Program
    {

        static Hotel CreateHotel()
        {
            Console.Write("Rate = ");
            var rateValue = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Currency = ");
            var currency = Convert.ToString(Console.ReadLine());

            var rate = new Rate(rateValue, currency);

            Console.Write("Room name = ");
            var roomName = Convert.ToString(Console.ReadLine());

            var room = new Room(roomName, 2, 0, rate);

            Console.Write("Hotel name = ");
            var hotelName = Convert.ToString(Console.ReadLine());

            var rooms = new List<Room> { room };

            var hotel = new Hotel(hotelName, "Iasi", 3, rooms);

            return hotel;
        }
        static void Main(string[] args)
        {
            

            var rate1 = new Rate(100, "USD");

            var rooms = new List<Room>();
            var room1 = new Room("Camera 1", 2, 0, rate1);
            var room2 = new Room("Camera 2", 2, 1, rate1);
            rooms.Add(room1);
            rooms.Add(room2);

            var hotel1 = new Hotel("Hotel 1", "Iasi", 3, rooms);
            hotel1.Print();


            var hotels = new List<Hotel>();
            hotels.Add(hotel1);

            var hotel2 = CreateHotel();
            hotel2.Print();

            hotels.Add(hotel2);

            foreach (var h in hotels)
            {
                h.Print();
            }
            Console.ReadKey();

        }
    }
}
