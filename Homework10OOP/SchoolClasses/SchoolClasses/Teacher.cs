using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Teacher: ITeacher
    {
        private IList<IDiscipline> _disciplines = new List<IDiscipline>();

        public Teacher(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public IList<IDiscipline> Disciplines
        {
            get { return _disciplines; }
            set { _disciplines = value; }
        }

       
        public void AddDiscipline(IDiscipline disciplines)
        {
            _disciplines.Add(disciplines);
        }
        public void Print()
        {
            Console.WriteLine($"\n Teacher {this.Name} teach following disciplines:");

            foreach(var disciplina in _disciplines)
            {
                disciplina.Print();
            }
        }
    }
}
