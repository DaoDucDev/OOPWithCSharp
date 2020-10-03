using System;

class Faculty : Employee
{
    private double officeHours;
    private string rank;

    public double getOfficeHours()
    {
        return officeHours;
    }

    public void setOfficeHours(double _officeHours)
    {
        officeHours = _officeHours;
    }

    public string getRank()
    {
        return rank;
    }

    public void setRank(string _rank)
    {
        rank = _rank;
    }
    public override double CalculateBonus()
    {
        return 1000 + 0.05 * base.getSalary();
    }

    public override int CalculateVacation()
    {
        int yearsService = DateTime.Now.Year - getHiredDate().Year;

        if (yearsService >= 3)
        {
            if (getRank() == "Senior Lecture")
            {
                return 6;
            }
            else
            {
                return 5;
            }
        }
        else
        {
            return 4;
        }
    }
}