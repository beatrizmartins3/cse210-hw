using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address()
    {
        _street= "Main street";
        _city="Chicago";
        _stateProvince="Illinois";
        _country="United States";
    }

    public Address(string street,string city,string sP,string country)
    {
        _street=street;
        _city=city;
        _stateProvince=sP;
        _country=country;
    }

    public string GetInside()
    {
        return $"{_street}, {_city}, {_stateProvince}/ country: {_country}.";
    }

    public string GetOutside()
    {
        return $"[Shipping outside the country]\n {_street}, {_city}, {_stateProvince}/ country: {_country}.";
    }
}