public class Activity
{
    

    protected string _endMessage;
    
    

    public Activity(string end)
    {
        
        _endMessage=end;
        
    }

    

    public string GetTime()
    {
        return _endMessage;
    }

    

    public virtual void GetActivity()
    {
        
        Console.WriteLine($"{ _endMessage}") ;
    }

}