public class ListGoals:Goal
{
    
    protected int _count;
    public ListGoals( string name, string descrip, string p) : base ( name, descrip, p) //, bonus,  many
    {
       // _count=count;
      
        
    }

    
    public string GetReturn(int _count)
    {
        return $"{_count}. {_name} ({_description})";
    }

    public override void  GetGoal()
    {
        _count++;
        
        

        Console.WriteLine("The Goals are:");
        Console.WriteLine(GetReturn(_count));
        
        
       
    }

}