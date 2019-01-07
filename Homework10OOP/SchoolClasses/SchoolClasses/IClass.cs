using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    interface IClass
    {
        string Name { get; set; }
        IList<IStudent> Students { get; set; }
        IList<ITeacher> Teachers { get; set; }
        void AddStudent(IStudent students);
        void RemoveStudent(IStudent students);
        void AddTeacher(ITeacher teachers);
        void RemoveTeacher(ITeacher teachers);
        void Print();
    }
}
