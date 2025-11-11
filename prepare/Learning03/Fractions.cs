using System.Diagnostics;

class Fractions
{
    private int top;
    private int bottom;

    public Fractions()
    {
        top = 1;
        bottom = 1;
    }

    public Fractions(int _top)
    {
        top = _top;
        bottom = 1;
    }

    public Fractions(int _top, int _bottom)
    {
        top = _top;
        bottom = _bottom;
    }

    public int GetTop()
    {
        return top;

    }

    public int GetBottom()
    {
        return bottom;

    }

    public void SetTop(int _top)
    {
        top = _top;
    }

    public void SetBottom(int _bottom)
    {
        bottom = _bottom;
    }

    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }
    
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}