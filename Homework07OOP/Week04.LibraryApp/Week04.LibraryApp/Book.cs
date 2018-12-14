using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.LibraryApp
{
    class Book
    {
        public Book(string genre, decimal price, string name)
        {
            this.Name = name;
            this.Genre = genre;
            this.Price = price;
            this.Author = new List<Author>();
        }

        public string Name { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public List<Author> Author { get; set; }

        public void AddAuthor(Author newAuthor)
        {
            Author.Add(newAuthor);
        }
        public decimal GetPrice()
        {
            if (Genre == "Drama")
            {
                return Price - (decimal)0.10 * Price;
            }
            else {
                if (Genre == "SF")
                {
                    return Price - (decimal)0.15 * Price;
                }
                else
                {
                    return Price;
                }
            }
        }
    }
}
