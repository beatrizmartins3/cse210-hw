using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eT, string descrip, string date, string time,  string weather) : base(eT, descrip, date, time)
    {
        _weather=weather;
    }

    public string GetW()
    {
        return $"Weather: {_weather}";
    }
}