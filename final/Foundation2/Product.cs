using System;

public class Product
{
    private string _nameP;
    private string _idP;
    private double _priceP;
    private int _quantityP;

    public Product()
    {
        _nameP= "Headphone";
        _idP="2105-15";
        _priceP= 15.90;
        _quantityP=3;
    }

    public Product(string nP,string id, double price,int quant)
    {
        _nameP=nP;
        _idP=id;
        _priceP=price;
        _quantityP=quant;
    }

    public string GetProduct()
    {
        string p= $"{_nameP}/ Product Id ({_idP})-- ${_priceP}. The quantity of units requested: {_quantityP}";
        return p;
    }

    public double GetPriceP()
    {
       double pP= _priceP * _quantityP;
       return pP;
    }
}