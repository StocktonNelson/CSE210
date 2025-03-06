using System.Drawing;

public class Circle : Shape
{
    // Private field
    private double _radius;

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Implementation of abstract method
    public override double GetArea()
    {
        // TO DO
        return Math.PI * Math.Pow(_radius, 2);
    }
}