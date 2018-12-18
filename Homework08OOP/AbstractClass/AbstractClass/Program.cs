using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Zoe", "A", 9.5);
            Student s2 = new Student("Diana", "B", 10);
            Student s3 = new Student("Alex", "C", 10);
            Student s4 = new Student("Gica", "E", 8);
            Student s5 = new Student("Viorica", "D", 4);
            Student s6 = new Student("Florin", "F", 5.70);
            Student s7 = new Student("Cristina", "G", 9);
            Student s8 = new Student("Gigi", "H", 10);
            Student s9 = new Student("Bibi", "I", 6);
            Student s10 = new Student("Dan", "J", 7);

            var listaStudenti = new List<Student>();

            listaStudenti.Add(s1);
            listaStudenti.Add(s2);
            listaStudenti.Add(s3);
            listaStudenti.Add(s4);
            listaStudenti.Add(s5);
            listaStudenti.Add(s6);
            listaStudenti.Add(s7);
            listaStudenti.Add(s8);
            listaStudenti.Add(s9);
            listaStudenti.Add(s10);

            var sortStudent = listaStudenti.OrderBy(s => s.Grade);

            foreach(var student in sortStudent)
            {
                Console.WriteLine($"Student {student.FirstName} {student.LastName} has {student.Grade} grade");
            }

            Worker w1 = new Worker("Dorel", "A", 500, 8);
            Worker w2 = new Worker("Viorel", "B", 400, 8);
            Worker w3 = new Worker("Costel", "C", 200, 6);
            Worker w4 = new Worker("Gica", "D", 650, 8);
            Worker w5 = new Worker("Mitica", "E", 500, 8);
            Worker w6 = new Worker("Dana", "F", 500, 8);
            Worker w7 = new Worker("Doina", "G", 300, 6);
            Worker w8 = new Worker("Mihai", "H", 400, 8);
            Worker w9 = new Worker("Tanda", "I", 250, 6);
            Worker w10 = new Worker("Manda", "J", 550, 8);

            var listaAngajati = new List<Worker>();

            listaAngajati.Add(w1);
            listaAngajati.Add(w2);
            listaAngajati.Add(w3);
            listaAngajati.Add(w4);
            listaAngajati.Add(w5);
            listaAngajati.Add(w6);
            listaAngajati.Add(w7);
            listaAngajati.Add(w8);
            listaAngajati.Add(w9);
            listaAngajati.Add(w10);

            var sortWorker = listaAngajati.OrderByDescending(w => w.MoneyPerHour());

            foreach (var worker in sortWorker)
            {
                Console.WriteLine($"Worker {worker.FirstName} {worker.LastName} is earning {worker.MoneyPerHour()}");
            }


            
            Console.ReadKey();
        }
    }
}
