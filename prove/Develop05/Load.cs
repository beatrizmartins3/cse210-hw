public class Load : Goal
{
    public Load(  string name, string descrip, string p) : base ( name, descrip, p) // bonus,  many
    {
        
    }

    public override void GetGoal()
    {

        Console.Write("What is the filename for the goal file? ");
        string filename=Console.ReadLine();
        
        string file = filename;
        string[] lines = System.IO.File.ReadAllLines(filename);
    
        foreach (string line in lines)
        {
            
            Console.WriteLine(line);
        }
    }

}