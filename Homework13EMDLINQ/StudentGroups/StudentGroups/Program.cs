using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 9. Student groups
            Student s1 = new Student("Noe", "Aionesei", 123406, 0700225588, "noe@yahoo.com", 2);
            s1.AddMark(9.5);
            s1.AddMark(8);
            s1.AddMark(6);
            s1.AddMark(10);

            Student s2 = new Student("Diana", "Balea",543212, 0722991177, "diana@yahoo.com", 1);
            s2.AddMark(6);
            s2.AddMark(7);
            s2.AddMark(10);
            s2.AddMark(10);

            Student s3 = new Student("Alex", "Constantin", 987406, 0711232323, "Alex@yahoo.com", 1);
            s3.AddMark(2);
            s3.AddMark(8.5);
            s3.AddMark(2);
            s3.AddMark(9);

            Student s4 = new Student("Sia", "Naomi", 939316, 0722667722, "sia@yahoo.com", 2);
            s4.AddMark(8);
            s4.AddMark(6);
            s4.AddMark(10);
            s4.AddMark(9);

            var listaStudenti = new List<Student>();

            listaStudenti.Add(s1);
            listaStudenti.Add(s2);
            listaStudenti.Add(s3);
            listaStudenti.Add(s4);

            foreach (var stud in listaStudenti)
            {
                stud.PrintStudentDetails();
            }

            var queryGroupNumber = listaStudenti.FindAll(s => s.GroupNumber == 2);

            foreach (var stud in queryGroupNumber)
            {
                stud.PrintStudentDetails();
            }

            var queryFirstName =
                from stud in listaStudenti
                orderby stud.FirstName
                select stud;

            foreach (var stud in queryFirstName)
            {
                stud.PrintStudentDetails();
            }

            //Problem 13. Extract students by marks
            var queryMark =
                from stud in listaStudenti
                where stud.Marks.Contains(6)
                select stud;

            foreach (var stud in queryMark)
            {
                stud.PrintStudentDetails();
            }

            //Problem 14. Extract students with two marks
            var queryMarks = listaStudenti.FindAll(x => x.Marks.Count(y => y == 2) == 2);

            foreach(var stud in queryMarks)
            {
                stud.PrintStudentDetails();
            }

            //Problem 15. Extract marks
            Console.WriteLine($"All Marks of the students that enrolled in 2006 : ");
            var queryEnrolled =
               from stud in listaStudenti
               where stud.FN.ToString().EndsWith("06")
               select stud;

            foreach (var stud in queryEnrolled)
            {
                stud.PrintStudentDetails();
            }

            //Problem 18. Grouped by GroupNumber
            Console.WriteLine($"All the students from group 1 : ");

            var queryFirstGroup =
               from stud in listaStudenti
               where stud.GroupNumber.Equals(1)
               select stud;
            foreach (var stud in queryFirstGroup)
            {
                stud.PrintStudentDetails();
            }

            Console.WriteLine($"-------------------------------");
            Console.WriteLine($"All the students from group 2 : ");
        
            var querySecondGroup =
               from stud in listaStudenti
               where stud.GroupNumber.Equals(2)
               select stud;
            foreach (var stud in querySecondGroup)
            {
                stud.PrintStudentDetails();
            }

            Console.ReadKey();
        }
    }
}
