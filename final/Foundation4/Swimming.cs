using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date,string act,int time,int distance,int laps): base( date, act,time,distance)
   
    {
        _laps=laps;
    }

    public double GetD()
    {
        double d=_laps*50/1000;
        return d;
    }

    public double GetS()
    {
        double s= (GetD()/_time)*60;
        return s;
    }

    public double GetPace()
    {
        double p= _time/GetD();
        return p;
    }
    
   
    
    public override void GetSummary()
    {
        
        
        
        Console.WriteLine($"{GetAct()}-Distance: {GetD(),0:F1} km, Speed: {GetS(),0:F1} kph, Pace: {GetPace(),0:F1} min per km ");
   
    }
}
