using System;

class Cylinder: Circle
{
    private double height;

    public double getHeight()
    {
        return height;
    }

    public double getVolume()
    {
        return height * base.getArea();
    }

    public new double getArea()
    {
        return base.getArea() * 2 + 2 * Math.PI * base.getRadius() * height;
    }

    public void setHeight(double _height)
    {
        height = _height;
    }
}