using System;

class Staff : Employee
{
    private string title;

    public string getTitle()
    {
        return title;
    }

    public void setTitle(string _title)
    {
        title = _title;
    }
    public override double CalculateBonus()
    {
        return 0.06 * base.getSalary();
    }

    public override int CalculateVacation()
    {
        int yearsService = DateTime.Now.Year - getHiredDate().Year;

        if(yearsService >= 5)
        {
            return 4;
        }
        else
        {
            return 3;
        }
    }
}