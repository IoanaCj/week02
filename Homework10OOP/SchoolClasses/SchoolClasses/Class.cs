using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Class: IClass
    {
        public Class(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        private IList<IStudent> _students = new List<IStudent>();

        private IList<ITeacher> _teachers = new List<ITeacher>();
        public IList<IStudent> Students
        {
            get {  return _students; }
            set { _students = value; }
        }
       
        public IList<ITeacher> Teachers {
            get { return _teachers; }
            set { _teachers = value; }
        }

        public void AddStudent(IStudent students)
        {
            _students.Add(students);
        }
        public void RemoveStudent(IStudent students)
        {
            _students.Remove(students);
        }
        public void AddTeacher(ITeacher teachers)
        {
            _teachers.Add(teachers);
        }
        public void RemoveTeacher(ITeacher teachers)
        {
            _teachers.Remove(teachers);
        }

        public void Print()
        {
            Console.WriteLine($" Class {this.Name} has following students and teacher: ");

            foreach (var studenti in _students)
            {
                studenti.Print();
            }

            foreach (var profesor in _teachers)
            {
                profesor.Print();
            }
        }

    }
}
