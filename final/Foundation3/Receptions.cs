using System;

public class Reception : Event
{
    private string _r;

    public Reception(string eT, string descrip, string date, string time, string r) : base(eT, descrip, date, time)
    {
        _r=r;
    }

    public string GetReception()
    {
        return $"Contact us: {_r}";
    }
}