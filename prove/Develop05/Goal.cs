public class Goal
{
    
    protected string _name;
    protected string  _description;
    protected string _points;

    
    public Goal( string name, string descrip, string p)
    {
       
        _name=name;
        _description=descrip;
        _points=p;
       
    }

    

    public virtual void GetGoal()
    {


        Console.WriteLine("Congratulations, you have completed a step in the process.");
        
        
        }

        
}

