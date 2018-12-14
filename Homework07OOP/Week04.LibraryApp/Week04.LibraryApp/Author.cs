using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04.LibraryApp
{
    class Author
    {
        public Author(string name, string email)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set { email = value; }
        }
    }
}
