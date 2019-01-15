using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Student("Ion", "Ion", "Ionescu", 325, "address", 0722334455, "A@a.com", ESpeciality.Civil, EFaculty.LawFaculty, EUniversity.Harvard);
            var y= new Student("Gica", "Noe", "Stroiescu", 213, "address", 0778855220, "A@a.com", ESpeciality.Physics, EFaculty.ScienceFaculty, EUniversity.UniversityOfHelsinki);

            //Problem 2. ICloneable
            var z = x.Clone() as Student;

            z.FirstName = "Vasile";

            x.PrintStudentDetails();

            //Problem 3. IComparable
            var list = new List<Student>();
            list.Add(x);
            list.Add(y);
            list.Add(x);
            list.Sort();

            foreach(var l in list)
            {
                l.PrintStudentDetails();
            }

            Console.ReadKey();

            
        }
    }
}
