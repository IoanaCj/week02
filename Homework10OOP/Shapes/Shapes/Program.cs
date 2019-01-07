using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IShape> figures = new List<IShape>();

            Shape triangle = new Triangle(new Position(0,0),10, 20);
            Shape rectangle = new Rectangle(new Position(0, 0), 15, 5);
            Shape square = new Square(new Position(0, 0), 5);

            figures.Add(triangle);
            figures.Add(rectangle);
            figures.Add(square);
            foreach(var fig in figures)
            {
                fig.PrintArea();
            }
            Console.ReadKey();
        }
    }
}
