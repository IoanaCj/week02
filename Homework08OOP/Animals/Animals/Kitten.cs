using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = "Female";
        }
    }
}
