public class Relax : Activity
{
    protected string _startMessage=" ";

    

    public Relax( string start, string end) : base (end) 
    {
        
        _startMessage=start;
        
    }
    
    public override void GetActivity()
    {
        Console.WriteLine("Welcome to the Relax Activity");
        Console.WriteLine();
        Console.WriteLine("List activities that make you relax.");
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

        List<string> values = new List<string>();
             Console.WriteLine("When you finish type 'done' ");
             while(true)
             {
                string input=Console.ReadLine();
                if (input.ToLower() == "done")
                    break;
                values.Add(input);
             }
             
             int size = values.Count;

             Console.WriteLine();
             Console.WriteLine($"You listed {size} items.");
             Console.WriteLine();

            
    }
}