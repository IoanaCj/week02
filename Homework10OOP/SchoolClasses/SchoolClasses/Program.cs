using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Popescu I","2B", "Present");
            Student s2 = new Student("Dolanescu G", "3A", "Present");
            Student s3 = new Student("Gigi A", "2B", "Absent");
            Student s4 = new Student("Aionei F", "3A", "Present");

            Disciplines d1 = new Disciplines("Mathematics", 10, 30);
            Disciplines d2 = new Disciplines("French", 6, 10);
            Disciplines d3 = new Disciplines("Physics", 15, 9);
            Disciplines d4 = new Disciplines("Nature science", 12, 20);

            Teacher t1 = new Teacher("First Teacher");
            t1.AddDiscipline(d1);
            t1.AddDiscipline(d3);
            Teacher t2 = new Teacher("Second Teacher");
            t2.AddDiscipline(d2);
            t2.AddDiscipline(d4);


            Class c1 = new Class("3A");
            c1.AddTeacher(t1);
            c1.AddStudent(s2);
            c1.AddStudent(s4);

            Class c2 = new Class("2B");
            c2.AddTeacher(t2);
            c2.AddStudent(s1);
            c2.AddStudent(s3);

            School s = new School("Ion Creanga", "Iasi");
            s.AddClass(c1);
            s.AddClass(c2);

            s.Print();

            Console.ReadKey();
        }
    }
}
