using System;
class People
{
    public string name;
    public int age;
    public string address;


    public People()
    {
        Console.WriteLine("Hi! I'm a human!");
    }
    public void SayHello()
    {
        Console.WriteLine("Hi! My name is {0}", name);
    }

    public void SayHello(int _age)
    {
        Console.WriteLine("Hi! My name is {0}. I'm {1}", name, _age);
    }

    public void SayHello(string _name)
    {
        Console.WriteLine("Hi! My name is {0}. I'm {1}", _name, age);
    }

    public void SayHello(string _name, int _age)
    {
        Console.WriteLine("Hi! My name is {0}. I'm {1}", _name, _age);
    }

    public string ShowInfo()
    {
        return "My name is " + name + "\nI'm " + age;
    }

    public virtual void XXX()
    {
        Console.WriteLine("Demo virtual method!");
    }
}