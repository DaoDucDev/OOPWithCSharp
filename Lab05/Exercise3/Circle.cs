using System;

class Circle : Shape
{
    private double radius = 1.0;

    public double getRadius()
    {
        return radius;
    }

    public void setRadius(double _radius)
    {
        radius = _radius;
    }
    public Circle() { }
    public Circle(double _radius) { }
    public Circle(double _radius, string _color, bool _filled) { }

    public double getArea()
    {
        return Math.PI * radius * radius;
    }

    public double getPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override string ToString()
    {
        return "A Circle with radius = " + radius + " which is a subclass of " + typeof(Circle).BaseType;
    }
}