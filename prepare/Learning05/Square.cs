using System;

public class Square : Shape
{
    private double _side;

    // Constructor receives color and side. 
    // Passes color up to the base Shape constructor.
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override the virtual method to calculate Square area
    public override double GetArea()
    {
        return _side * _side;
    }
}