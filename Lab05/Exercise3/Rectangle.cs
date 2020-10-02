class Rectangle : Shape
{
    private double width = 1.0;
    private double length = 1.0;

    public Rectangle() { }
    public Rectangle(double _width, double _length) { }

    public Rectangle(double _width, double _length, string _color, bool _filled) { }

    public double getWidth()
    {
        return width;
    }

    public void setWidth(double _width)
    {
        width = _width;
    }

    public double getLength()
    {
        return length;
    }

    public void setLength(double _length)
    {
        length = _length;
    }

    public double getArea()
    {
        return width * length;
    }

    public double getPerimeter()
    {
        return (width + length) * 2;
    }

    public override string ToString()
    {
        return "A Rectangle with width = " + width + " and length = " + length + " which is a subclass of " + typeof(Rectangle).BaseType  + "\n" + base.ToString();
    }

}