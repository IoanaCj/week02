using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    interface ISchool
    {
        string Name { get; set; }
        string Address { get; set; }
        IClass Classes { get; set; }
        void AddClass(IClass classes);
        void RemoveClass(IClass classes);
    }
}
