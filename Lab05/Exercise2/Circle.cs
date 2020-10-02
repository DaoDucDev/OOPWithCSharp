using System;

class Circle
{
    protected double radius;
    protected string color;

    public double getRadius()
    {
        return radius;
    }

    public string getColor()
    {
        return color;
    }

    public double getArea()
    {
        return Math.PI * radius * radius;
    }
}