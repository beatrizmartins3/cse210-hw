using System;

public class Square : Shape
{
    private double _side=0;

    public Square(string color ,double side) : base(color)
    {
        _side=side;
    }

    //public double GetSide()
    //{
    //return _side;
    //}

    //public void SetSide(double side)
    //{
    //_side=side;
    //}
    public override double GetArea()
    {
        return Math.Pow(_side,2);
    }
}
