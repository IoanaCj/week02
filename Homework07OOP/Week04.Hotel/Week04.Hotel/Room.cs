using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.Hotel
{
    class Room
    {
        public Room(string name, int adults, int children, Rate rate)
        {
            this.Name = name;
            this.Adults = adults;
            this.Children = children;
            this.Rate = rate;
        }
        public string Name { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Rate Rate { get; set; }

        public decimal GetPrice()
        {
            if (this.Children >= 1)
            {
                return Rate.Amount * Convert.ToDecimal(1.3);
            }
            return this.Rate.Amount;
        }

        public void Print()
        {
            Console.WriteLine($"\t Room {Name} : ");
            Console.WriteLine($"\t\t Adults {Adults}, Chhildren {Children}");
            this.Rate.Print();                                               //de ce? se numeste delegarea responsabilitatii

            Console.WriteLine($"After calculation {this.GetPrice()}");
        }
    }
}
