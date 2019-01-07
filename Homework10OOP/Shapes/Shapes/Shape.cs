using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape: IShape
    {
        public Shape(Position point)
        {
            this.Point = point;
        }
        public Position Point { get; }
        public abstract double CalculateSurface();
        public abstract string FigureType();

        public virtual void PrintArea()
        {
            Console.WriteLine($" The area of the {this.FigureType()} is {this.CalculateSurface()}");
        }
    }
}
