abstract class Shape
{
    //Field
    private string color;
    //private field
    private double area;

    //Abstract property
    public abstract double Area{get;} 


    //Property
    public string Color
    {
        get { return color.ToUpper(); }
        set {color = value;}
    }

    public string Name { get; set; }
}