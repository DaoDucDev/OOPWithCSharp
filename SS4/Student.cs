using System;

class Student
{
    //Attributes
    public string Name;
    public int Age;
    public string Address;

    //Methods
    public void SayHello()
    {
        Console.WriteLine("Hi! My name is {0}", Name);
    }
}