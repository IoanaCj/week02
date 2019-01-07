using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    interface ITeacher : IPeople
    {
    
        IList<IDiscipline> Disciplines { get; set; }
        void AddDiscipline(IDiscipline disciplines);
        void Print();
    }
}
