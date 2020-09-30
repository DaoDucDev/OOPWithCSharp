using System;

class Student : People
{
    public string id;
    public string email;

    public void Study()
    {
        Console.WriteLine("I'm a student! I'm learning!!!");
    }

    public override void XXX()
    {
        base.XXX();
        
    }
}