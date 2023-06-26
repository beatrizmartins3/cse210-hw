using System;
using System.IO;

public class Save : Goal
{

    
    public Save(  string name, string descrip, string p) : base ( name, descrip, p)  
    {
        
    }
   
    public override void GetGoal()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename=Console.ReadLine();
        
        string file = filename;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_name}, {_description}, {_points}");
            
        }

    }
    
        

}