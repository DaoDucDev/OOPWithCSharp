class Shape
{
    private string color = "red";
    private bool filled = true;

    public Shape(){}
    public Shape(string _color, bool _filled)
    {
        color = _color;
        filled = _filled;
    }

    public string getColor()
    {
        return color;
    }

    public void setColor(string _color)
    {
        color = _color;
    }

    public bool isFilled()
    {
        return filled;
    }

    public void setFilled(bool _filled)
    {
        filled = _filled;
    }

    public override string ToString()
    {
        if(filled == true)
        {
            return "A Shape with color of " + color + " and filled";
        }
        else
        {
            return "A Shape with color of " + color + " and not filled";
        }
    }
}