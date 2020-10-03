class Person
{
    protected string name;
    protected string phoneNumber;
    protected string email;

    public string getName()
    {
        return name;
    }

    public void setName(string _name)
    {
        name = _name;
    }

    public string getPhoneNumber()
    {
        return phoneNumber;
    }

    public void setPhoneNumber(string _phoneNumber)
    {
        phoneNumber = _phoneNumber;
    }

    public string getEmail()
    {
        return email;
    }

    public void setEmail(string _email)
    {
        email = _email;
    }


    public override string ToString()
    {
        string result = "Class name: " + this.GetType().ToString() + "\nPerson's name: " + name + "\nEmail: " + email;
        return result;
    }
}