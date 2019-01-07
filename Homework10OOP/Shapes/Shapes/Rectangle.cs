using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle: Shape
    {
        public Rectangle(Position basePoint, int width, int height) : base(basePoint)
        {
            this.Width = width;
            this.Height = height;
        }
        private int Width { get; set; }
        private int Height { get; set; }

        public override double CalculateSurface()
        {
            return (double)Height * Width;
        }

        public override string FigureType()
        {
            return "Rectangle";
        }
        public override void PrintArea()
        {
            Console.WriteLine($" The area of the {this.FigureType()} is {this.CalculateSurface()}");
        }
    }
}
