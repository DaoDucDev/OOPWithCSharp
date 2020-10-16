using System.Collections.Generic;

class Student
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private string address;
    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    private List<Subject> subjects;
    public List<Subject> Subjects
    {
        get { return subjects; }
        set { subjects = value; }
    }
    

    public Student() { }
    public Student(string _name, int _age, string _address)
    {
        Name = _name;
        Age = _age;
        Address = _address;
    }

}