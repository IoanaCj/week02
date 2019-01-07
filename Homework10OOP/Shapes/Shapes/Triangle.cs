using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(Position basePoint, int width, int height) : base(basePoint)
        {
            this.Width = width;
            this.Height = height;
        }
        private int Width { get; set; }
        private int Height { get; set; }

        public override double CalculateSurface()
        {
            return (double)Height * Width / 2;
        }

        public override string FigureType()
        {
            return "Triangle";
        }
        public override void PrintArea()
        {
            Console.WriteLine($" The area of the {this.FigureType()} is {this.CalculateSurface()}");
        }
    }
}
