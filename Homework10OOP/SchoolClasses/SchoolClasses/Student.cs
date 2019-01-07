using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Student: IStudent
    {
        public Student(string name, string classNumber, string studentStatus)
        {
            Name = name;
            ClassNumber = classNumber;
            StudentStatus = studentStatus;
        }
        public string Name { get; set; }
        public string ClassNumber { get; set; }
        public string StudentStatus { get; set; }

        public void Print()
        {
            Console.WriteLine($"\n {this.Name} from {this.ClassNumber} is {this.StudentStatus}.");
        }
    }
}
