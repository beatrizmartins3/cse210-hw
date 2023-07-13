using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> act= new List<Activity>();

        Running run= new Running("11 Jul 2023","Running",30,4800);
        act.Add(run);
        Cycling cyc=new Cycling("10 Jul 2023","Cycling",25,5000);
        act.Add(cyc);
        Swimming swim=new Swimming("12 Jul 2023","Swimming",15,200,5);
        act.Add(swim);

        foreach (Activity a in act)
        {
           
            a.GetSummary();

            Console.WriteLine(a);
    
        }

    



    }
}