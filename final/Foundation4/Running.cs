using System;

public class Running : Activity
{
    

    public Running(string date,string act,int time,int distance): base( date, act,time,distance)
   
    {
        
    }

   
    
    public override void GetSummary()
    {
        int d=_distance/1000;
        float s= d/_time*60;
        float p= _time/d;
        Console.WriteLine($"{GetAct()}-Distance: {d,0:F1} km, Speed: {s,0:F1} kph, Pace: {p,0:F1} min per km ");
   
    }
}
