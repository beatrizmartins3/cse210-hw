using System;
using System.IO;

public class Save : Goal
{

    //Console.Write("What is the filename for the goal file?");
    //string filename=Console.ReadLine();
    public Save(  string name, string descrip, string p) : base ( name, descrip, p)  //, bonus,  many
    {
        
    }
   
    public override void GetGoal()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename=Console.ReadLine();
        
        //string[] lines = { _name, _description, _points.ToString(),_bonus.ToString(), };
        //string docPath =
          //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
          //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, filename)))
        //{
            //foreach (string line in lines)
                //outputFile.WriteLine(line);
        //}
        string file = filename;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_name}, {_description}, {_points}");
            //outputFile.WriteLine(GetG());
            //string color = "Blue";
            //outputFile.WriteLine($"My favorite color is {color}");

        }

    }
    
        

}