class Shape
{
    //Field
    private string color;
    //Property
    public string Color
    {
        get { return color.ToUpper(); }
        set {color = value;}
    }

    public string Name { get; set; }
}