using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.LibraryApp
{
    class Library
    {
        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public void AddBook(Book b1)
        {
            this.Books.Add(b1);
        }
        public void DeleteBook(Book b2)
        {
            this.Books.Remove(b2);
        }

    }
}
