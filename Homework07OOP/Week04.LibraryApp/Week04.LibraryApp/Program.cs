using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library librarie = new Library("Univers");

            Author a1 = new Author("Elif Shafak", "elif.shafak@yahoo.com");
            Author a2 = new Author("Frank Herbert", "Frank.Herbert@yahoo.com");

            Book b1 = new Book("Bastarda Istanbulului", 50, "Drama");
            Book b2 = new Book("Cele 40 de legi ale iubirii", 30, "Fictiune");
            Book b3 = new Book("Copiii Dunei", 150, "SF");
            Book b4 = new Book("Ereticii Dunei", 170, "Drama");

            b1.AddAuthor(a1);
            b2.AddAuthor(a1);
            b3.AddAuthor(a2);
            b4.AddAuthor(a2);

            librarie.AddBook(b1);
            librarie.AddBook(b2);
            librarie.AddBook(b3);
            librarie.AddBook(b4);
        }
    }
}
