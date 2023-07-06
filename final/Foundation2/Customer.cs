using System;

public class Customer
{
    private string _name;

    public Customer()
    {
        _name= "Liz Grey ";
    }

    public Customer(string name)
    {
        _name=name;
    }

    public string GetName()
    {
        return _name;
    }
}