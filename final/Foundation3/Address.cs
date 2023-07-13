using System;

public class Address
{
    private string _city;
    private string _street;
    private string _number;

    public Address(string city,string st,string num)  
    {
        _city=city;
        _street=st;
        _number=num;

    }

    public string GetAddress()
    {
        return $"Local: {_city},{_street},{_number}" ;
    }
 
}