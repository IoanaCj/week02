using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4Person_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new  Person("Dolanescu");
            p1.PrintPersonDetails();
            Console.WriteLine(p1.ToString());

            Person p2 = new Person("Popescu");
            p2.AddPersonAge(10);
            p2.PrintPersonDetails();
            Console.WriteLine(p2.ToString());

            Console.ReadKey();

        }
    }
}
