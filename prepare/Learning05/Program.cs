using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(3, "Purple"));
        shapes.Add(new Rectangle(7, 3, "Red"));
        shapes.Add(new Circle(9, "Yellow"));
        shapes.Add(new Square(34, "Teal"));
        shapes.Add(new Rectangle(2, 84, "Cyan"));
        shapes.Add(new Circle(81, "Magenta"));
        shapes.Add(new Square(14, "Black"));
        shapes.Add(new Rectangle(14, 326, "Tan"));
        shapes.Add(new Circle(19, "Orange"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()} | Shape Area: {shape.GetArea()}");
        }
    }
}