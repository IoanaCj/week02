using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4Person_Class
{
    class Person
    {
        public string Name { get; set; }
        public int? Age;

        public Person(string name)
        {
            this.Name = name;
        }
        public void AddPersonAge(int age)
        {
            this.Age = age;
        }
        public override string ToString()
        {
            if(this.Age == null)
            {
                return this.Name + " " + "age is not specified for this person";
            }
            return this.Name +" " + this.Age;
        }
        public void PrintPersonDetails()
        {
            Console.WriteLine($"\t {this.Name} is {this.Age} years old");
        }
    }
}
