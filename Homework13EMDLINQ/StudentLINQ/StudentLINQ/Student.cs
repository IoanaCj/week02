using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLINQ
{
    class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void PrintStudentDetails()
        {
            Console.WriteLine($"Student {FirstName} {LastName} is {Age} years old");
        }
    }
}
