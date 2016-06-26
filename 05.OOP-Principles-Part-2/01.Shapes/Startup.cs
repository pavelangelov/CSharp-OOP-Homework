namespace Shapes
{
    using System;
    using Models;

    class Startup
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(3, 3),
                new Rectangle(5, 3),
                new Square(4),
                new Triangle(5, 3),
                new Rectangle(6, 5),
                new Square(6.3)
            };

            Square sq = new Square(5);
            Triangle tr = new Triangle(2, 3);

            foreach (var shape in shapes)
            {
                Console.WriteLine($"This {shape.GetType().Name} Surface = {shape.CalculateSurface()}");
            }
        }

    }
}
