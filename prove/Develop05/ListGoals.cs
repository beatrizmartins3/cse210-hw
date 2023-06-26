public class ListGoals:Goal
{
    
    protected int _count;
    List<Goal> goals = new List<Goal>();
    public ListGoals( string name, string descrip, string p) : base ( name, descrip, p) //, bonus,  many
    {
       
    }
    
    
    
    public string GetReturn()
    {
        _count++;
        return $"{_count}. {_name} ({_description}), {_points} points";
    }

    public override void  GetGoal()
    {
        

        Console.WriteLine("The Goals are:");
        Console.WriteLine(GetReturn());
        
    }

}