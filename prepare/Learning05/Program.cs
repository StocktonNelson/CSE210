using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        
        Shape square = new Square("Red", 5);
        Shape rectangle = new Rectangle("Blue", 4, 6);
        Shape circle = new Circle("Green", 3);

        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            
            Console.WriteLine($"The {shape.GetType().Name} is {color} and has an area of {area}");
        }
    }
}