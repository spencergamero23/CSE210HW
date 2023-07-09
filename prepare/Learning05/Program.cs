using System;

namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Red", 4);
            Console.WriteLine(square.GetColor());
            Console.WriteLine(square.GetArea());

            Rectangle rectangle = new Rectangle("Blue", 5, 4);
            Console.WriteLine(rectangle.GetColor());
            Console.WriteLine(rectangle.GetArea());

            Circle circle = new Circle("Green", 12);
            Console.WriteLine(circle.GetColor());
            Console.WriteLine(circle.GetArea());

            List<Shape> shapes = new List<Shape>();

            shapes.Add(rectangle);
            shapes.Add(circle);
            shapes.Add(square);

            foreach(Shape s in shapes)
            {
                string color = s.GetColor();

                double area = s.GetArea();

                Console.WriteLine($"The shape that's colored {color} has an area of {area}");
            }

        }
    }
}