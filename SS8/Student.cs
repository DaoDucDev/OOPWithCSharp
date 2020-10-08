using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Student: IComparer<Student>, IComparable<Student>
{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private string name;
    public string Name
    {
        get { return name.ToUpper(); }
        set { name = value; }
    }

    private double mathScore;
    public double MathScore
    {
        get { return mathScore; }
        set { mathScore = value; }
    }
    
    
    public Student(){}
    public Student(int _id, string _name)
    {
        Id = _id;
        Name = _name;
    }

    public Student(int _id, string _name, double _mathScore)
    {
        Id = _id;
        Name = _name;
        MathScore = _mathScore;
    }

    public int Compare(Student std1, Student std2)
    {
        return std1.Name.CompareTo(std2.Name);
    }

    public int CompareTo([AllowNull] Student other)
    {
        return this.Name.CompareTo(other.Name);
    }
}
