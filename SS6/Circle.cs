using System;

class Circle : Shape
{
    private double radius;
    public override double Area 
    {
        get
        {
            return radius * radius * Math.PI;
        }
    }
}