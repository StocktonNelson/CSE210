public class Square : Shape
{
    // Private field
    private double _side;
    
    // Constructor
    public Square(string color , double side) : base(color)
    {
        // TO DO
        _side = side;
    }

    // Implementation of abstract method
    public override double GetArea()
    {
        // TO DO
        return Math.Pow(_side, 2);
    }
}