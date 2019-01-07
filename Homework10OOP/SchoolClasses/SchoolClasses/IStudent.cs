using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    interface IStudent : IPeople
    {
        string ClassNumber { get; set; }
        string StudentStatus { get; set; }
        void Print();
    }
}
