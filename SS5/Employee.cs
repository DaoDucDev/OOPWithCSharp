using System;

class Employee: People
{
    //Ko khai báo access modifier thì mặc định là private
    double salary;

    public Employee()
    {
        Console.WriteLine("Hi! I'm an employee!");
    }
    public void TingTing()
    {
        Console.WriteLine("Luong ve! Suong qua!!!");
    }

    public string ShowInfo()
    {
        return base.ShowInfo() + "\nI'm an employee of VTC Academy";
        
    }

    public string getName()
    {
        return base.name;
    }
}