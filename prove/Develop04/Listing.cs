public class Listing: Activity
{


    private string _startMessage="";

    public Listing( string start, string end ) : base (end) 
    {
        
        _startMessage=start;
        
    }

    public override void GetActivity()
    {
        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
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


        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine();
        string [] questions={
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
            };

            Random random = new Random();
            int index = random.Next(questions.Length);
            string sentence = questions[index];

            Console.WriteLine(sentence);

            Console.WriteLine("You may begin in: ");
            for (int i=5; i>0; i--)
            {
                
                Console.Write(i);
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

             Console.WriteLine($"You listed {size} items.");
             Console.WriteLine();
             Console.WriteLine($"You have completed another {time} seconds of the reflecting activity.");
             Console.WriteLine();

    }


    

}

