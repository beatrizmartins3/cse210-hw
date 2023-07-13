using System;

public abstract class Activity
{
    protected string _date;
    protected string _activity;
    protected int _time=0;

    protected int _distance=0;
    



    public Activity(string date,string act,int time,int distance)
    {
        _date=date;
        _activity=act;
        _time=time;
        _distance=distance;
        
    }

    public string GetAct()
    {
        return $"{_date} {_activity} {_time} min ";
    }

   
    
    

    public abstract void GetSummary();
    


} 