using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class Student
    {
        public Student(string firstName, string lastName, int fn, int phone, string email, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Phone = phone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = new List<double>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int GroupNumber { get; set; }

        public List<double> Marks = new List<double>();
        public void AddMark(double note)
        {
            Marks.Add(note);
        }
        public void PrintStudentDetails()
        {
            Console.WriteLine($"Student {FirstName} {LastName} from {GroupNumber} has following marks : ");
            foreach(var note in Marks)
            {
                Console.WriteLine(note);
            }
        }
    }
}
