using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Disciplines: IDiscipline
    {
        public Disciplines(string name, int numberOfLectures, int numberOfExercises)
        {
            Name = name;
            NumberOfLectures = numberOfLectures;
            NumberOfExercises = numberOfExercises;
        }
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t {Name} with {NumberOfLectures} lectures and {NumberOfExercises} exercises");
        }
    }
}
