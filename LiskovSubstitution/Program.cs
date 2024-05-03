using LiskovSubstitution;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Liskov Substitution************");

            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(),
                new Rectangle(),
                new Triangle(),
                new Triangle()

            };
            
            foreach(Shape shape in shapes )
            {
                shape.SetWidth(10);
                shape.SetHeight(10);
                shape.CalculateArea();
            }

            List<IBaseShape> baseShapes = new List<IBaseShape>()
            {
                new Square(),
                new Square()
            };

            foreach (var baseShape in baseShapes)
            {
                baseShape.SetWidth(10);
                baseShape.CalculateArea();
            }
        }
    }
}