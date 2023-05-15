using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top=1;
        _bottom=1;
    }

    public Fraction(int wholeFrac)
    {
        _top=wholeFrac;
        _bottom=1;
    }

    public Fraction(int top, int bottom)
    {
        _top=top;
        _bottom=bottom;
    }

    public string GetFractionString()
    {
        string result = $"{_top}/{_bottom}";
        return result;
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}