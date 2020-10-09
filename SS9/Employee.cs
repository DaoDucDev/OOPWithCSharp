class Employee
{
    //Delegate đại diện cho các method có kiểu (doube) -> (double)
    public delegate double Tax(double salary);

    public Tax GetTax(string countryCode)
    {
        if (countryCode == "VN")
        {
            //Anonymus Method - Phương thức nặc danh
            Tax vnTax = delegate (double salary)
            {
                return 10 * salary / 100;
            };

            return vnTax;
        }
        else if (countryCode == "CN")
        {
            Tax cnTax = delegate (double salary)
            {
                return 5 * salary / 100;
            };

            return cnTax;
        }
        else
        {
            return delegate (double salary)
            {
                return 7 * salary / 100;
            };
        }


    }
}