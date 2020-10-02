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
        Person p = new Person();
        string result = "Class name: " + p.GetType().ToString() + "\nPerson's name: " + p.name + "\nEmail: " + p.email;
        return result;
    }
}