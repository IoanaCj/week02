using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square: Shape
    {
        public Square(Position basePoint, int l) : base(basePoint)
        {
            this.L = l;
        }
        private int L { get; set; }

        public override double CalculateSurface()
        {
            return (double)L * L;
        }

        public override string FigureType()
        {
            return "Square";
        }
        public override void PrintArea()
        {
            Console.WriteLine($" The area of the {this.FigureType()} is {this.CalculateSurface()}");
        }
    }
}
