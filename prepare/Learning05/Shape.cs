using System;

public class Shape
{
    // Member variable for color
    private string _color;

    // Constructor accepts the color and sets it
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    // Setter for color
    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method for GetArea().
    // It returns a default value here, but will be overridden in derived classes.
    public virtual double GetArea()
    {
        return 0;
    }
}