public class Breathing : Activity
{
    
      
    private string _startMessage="";


    public Breathing( string start, string end) : base (end) 
    {
        
        _startMessage=start;
        
    }
    public override void GetActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();
        Console.WriteLine("How many time do you want in seconds? ");
        int time = Convert.ToInt32(Console.ReadLine());
       

        
        Console.WriteLine("Get ready...");
        List <string> animationStrings= new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine("Breathing in");

        for (int i=time; i>0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            
            
        }
        Console.WriteLine("Well done!!");
        Console.WriteLine();

        Console.WriteLine("Breathing out");
        for (int i=time; i>0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
          
        }
        Console.WriteLine(" Well done!!");
        List <string> animation= new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        
        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

        Console.WriteLine($"You have completed another {time} seconds of the reflecting activity.");

        List <string> aStrings= new List<string>();
        aStrings.Add("|");
        aStrings.Add("/");
        aStrings.Add("-");
        aStrings.Add("\\");
        aStrings.Add("|");
        aStrings.Add("/");
        aStrings.Add("-");
        aStrings.Add("\\");
        
        foreach (string s in aStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        
    }
}