using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Azorel", 5, "Male");
            Frog f = new Frog("Oaki", 1, "Male");
            Cat c = new Cat("Fifi", 6, "Female");
            Kitten k = new Kitten("Biscuit", 2, "Female");
            Tomcat t = new Tomcat("Yari", 10, "Male");

            var listaAnimale = new List<Animal>();

            listaAnimale.Add(d);
            listaAnimale.Add(f);
            listaAnimale.Add(c);
            listaAnimale.Add(k);
            listaAnimale.Add(t);

           foreach(var a in listaAnimale)
            {
                Console.WriteLine($"{a.Name}, {a.Age}, {a.Gender}");
            }

            double averageAge = 0;
            double counter = 0;

            foreach(var x in listaAnimale)
            {
                averageAge = averageAge + (double)x.Age / 5;
                counter++;
            }
            Console.WriteLine($"Average age of the animals is: {averageAge}"); 

            Console.ReadKey();
        }
    }
}
