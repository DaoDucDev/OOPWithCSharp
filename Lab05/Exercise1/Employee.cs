using System;

abstract class Employee: Person
{
    //Attribute or field
    private string department;
    private double salary;
    private DateTime hiredDate;

    public string getDepartment()
    {
        return department;
    }

    public void setDepartment(string _department)
    {
        department = _department;
    }

    public double getSalary()
    {
        return salary;
    }

    public void setSalary(double _salary)
    {
        salary = _salary;
    }

    public DateTime getHiredDate()
    {
        return hiredDate;
    }

    public void setHiredDate(DateTime _hiredDate)
    {
        hiredDate = _hiredDate;
    }

    public abstract double CalculateBonus();

    public abstract int CalculateVacation();
}