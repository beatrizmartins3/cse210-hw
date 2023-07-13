using System;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    

    public Event(string eT, string descrip, string date, string time)
    {
        _eventTitle=eT;
        _description=descrip;
        _date=date;
        _time=time;
        
    }

    public string GetEvent()
    {
        return _eventTitle;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    
    public  virtual  void GetMessage()
    {
        Console.WriteLine( $"The event is: {_eventTitle}\n{_description}\n Will be held on: {_date} \n At {_time} pm\n");
    }



}