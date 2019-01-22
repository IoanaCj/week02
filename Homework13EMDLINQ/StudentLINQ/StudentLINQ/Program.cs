using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ana", "Simion", 15);
            Student s2 = new Student("Dorin", "Popescu", 21);
            Student s3 = new Student("Diana", "Aionei", 34);
            Student s4 = new Student("Gigi", "Stolescu", 19);

            Student[] studenti = new Student[] { s1, s2, s3, s4 };

            //Problem 3. First before last
            var queryCompareNames =
                from stud in studenti
                where stud.FirstName.CompareTo(stud.LastName)< 0 //firstname before lastname alphabetical order
                select stud;

            foreach (var stud in queryCompareNames)
            {
                stud.PrintStudentDetails();
            }

            //Problem 4. Age range
            var queryAgeRange =
                from stud in studenti
                where (stud.Age >= 18 && stud.Age <= 24)
                select stud;

            foreach (var stud in queryAgeRange)
            {
                stud.PrintStudentDetails();
            }

            //Problem 5. Order students
            var sortareStudenti = studenti.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);

            foreach (var studsort in sortareStudenti)
            {
                studsort.PrintStudentDetails();
            }

            var queryOrderDescending =
                from stud in studenti
                orderby stud.FirstName descending, stud.LastName descending
                select stud;

            foreach (var stud in queryOrderDescending)
            {
                stud.PrintStudentDetails();
            }


           Console.ReadKey();
        }
    }
}
