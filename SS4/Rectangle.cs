using System;

class Rectangle
{
    private int width;
    private int height;

    public Rectangle(){}
    public Rectangle(int _width, int _height)
    {
        width = _width;
        height = _height;
    }

    public int getWidth()
    {
        return width;
    }

    public void setWidth(int _width)
    {
        width = _width;
    }

    public int getHeight()
    {
        return height;
    }

    public void setHeight(int _height)
    {
        height = _height;
    }

    public void display()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

    public int getArea()
    {
        return width * height;
    }

    public int getPerimiter()
    {
        return (width + height) * 2;
    }
}