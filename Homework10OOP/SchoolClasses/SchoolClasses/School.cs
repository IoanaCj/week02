using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class School : ISchool
    {
        public School(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public IClass Classes { get; set; }

        public List<IClass> _class = new List<IClass>();
        public void AddClass(IClass cl)
        {
            _class.Add(cl);
        }
        public void RemoveClass(IClass classes)
        {
            _class.Remove(classes);
        }
        public void Print()
        {
            Console.WriteLine($" {this.Name} school from {this.Address} has following classes: ");

            foreach (var clase in _class)
            {
                clase.Print();
            }
        }
    }
}
