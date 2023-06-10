public class Reflection : Activity
{
    private string _startMessage="";

    public Reflection( string start, string end) : base (end) 
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

            

            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            string [] questions={
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless.---"
            };

            Random random = new Random();
            int index = random.Next(questions.Length);
            string sentence = questions[index];

            Console.WriteLine(sentence);

            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.WriteLine("You may begin in: ");
            for (int i=5; i>0; i--)
            {
                
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            
            }
            
            Console.WriteLine();

            //SUB 1
        
            string [] ques={
                "> Why was this experience meaningful to you?",
                "> Have you ever done anything like this before?",
                "> How did you get started?",
                "> How did you feel when it was complete?",
                "> What made this time different than other times when you were not as successful?",
                "> What is your favorite thing about this experience?",
                "> What could you learn from this experience that applies to other situations?",
                "> What did you learn about yourself through this experience?",
                "> How can you keep this experience in mind in the future?"
              
            };
                Random randoms = new Random();
                int ind = randoms.Next(ques.Length);
                string sen= ques[ind];
                Console.WriteLine(sen);

                List <string> anim= new List<string>();
                anim.Add("|");
                anim.Add("/");
                anim.Add("-");
                anim.Add("\\");
                anim.Add("|");
                anim.Add("/");
                anim.Add("-");
                anim.Add("\\");
                
                DateTime startTime= DateTime.Now;
                DateTime endTime=startTime.AddSeconds(10);

                int b=0;

                while(DateTime.Now<endTime)
                {
                    string g= anim[b];
                    Console.Write(g);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");

                    b++;

                    if(b>=anim.Count)
                    {
                        b=0;
                    }

                }

                Console.WriteLine();

                //SUB 2

                string [] que={
                "> Why was this experience meaningful to you?",
                "> Have you ever done anything like this before?",
                "> How did you get started?",
                "> How did you feel when it was complete?",
                "> What made this time different than other times when you were not as successful?",
                "> What is your favorite thing about this experience?",
                "> What could you learn from this experience that applies to other situations?",
                "> What did you learn about yourself through this experience?",
                "> How can you keep this experience in mind in the future?"
              
                };
                Random ran = new Random();
                int inde = ran.Next(ques.Length);
                string sent= que[inde];
                Console.WriteLine(sent);

                List <string> animation= new List<string>();
                animation.Add("|");
                animation.Add("/");
                animation.Add("-");
                animation.Add("\\");
                animation.Add("|");
                animation.Add("/");
                animation.Add("-");
                animation.Add("\\");
                
                DateTime start= DateTime.Now;
                DateTime end=start.AddSeconds(10);

                int c=0;

                while(DateTime.Now<end)
                {
                    string g= anim[c];
                    Console.Write(g);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");

                    c++;

                    if(c>=anim.Count)
                    {
                        c=0;
                    }

                }



                //SUB 3
                Console.WriteLine();

                string [] q={
                "> Why was this experience meaningful to you?",
                "> Have you ever done anything like this before?",
                "> How did you get started?",
                "> How did you feel when it was complete?",
                "> What made this time different than other times when you were not as successful?",
                "> What is your favorite thing about this experience?",
                "> What could you learn from this experience that applies to other situations?",
                "> What did you learn about yourself through this experience?",
                "> How can you keep this experience in mind in the future?"
                };
                Random r = new Random();
                int idx = r.Next(q.Length);
                string senten= q[idx];
                Console.WriteLine(senten);

                List <string> animStrings= new List<string>();
                animStrings.Add("|");
                animStrings.Add("/");
                animStrings.Add("-");
                animStrings.Add("\\");
                animStrings.Add("|");
                animStrings.Add("/");
                animStrings.Add("-");
                animStrings.Add("\\");

                DateTime sTime= DateTime.Now;
                DateTime eTime=sTime.AddSeconds(10);

                int t=0;
                
                while(DateTime.Now<eTime)
                {
                    string g= anim[t];
                    Console.Write(g);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");

                    t++;

                    if(t>=anim.Count)
                    {
                        t=0;
                    }

                }

                Console.WriteLine();
                Console.WriteLine($"You have completed another {time} seconds of the reflecting activity.");
                Console.WriteLine();
    
    }
  
    
}