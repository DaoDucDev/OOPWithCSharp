class Square : Rectangle
{
    public Square() { }

    public Square(double _side) : base(_side, _side) 
    {
        base.setWidth(_side);
        base.setLength(_side);
    }

    public double getSide()
    {
        return base.getLength();
    }
    public Square(double _side, string _color, bool _filled) { }

    public override string ToString()
    {
        return "A Square with side = " + getSide() + " which is a subclass of " + typeof(Square).BaseType  + "\n" + base.ToString();
    }
}