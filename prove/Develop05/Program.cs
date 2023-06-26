using System;

class Program
{
    

    static void Main(string[] args)
    {
        string userValue;
        string points="";
        Goal g;
        string n="";
        string d="";
        string pt="0";
        int b;
        int mB;
        int cGoal;
        
        
         
        do
        {
            Console.WriteLine($"You have {pt} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit ");
            Console.Write("Select a choice from the menu: ");
            userValue= Console.ReadLine();

             
            if (userValue=="1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");


                Console.Write("Wich type of goal would you like to create? ");
                int _type = Convert.ToInt32(Console.ReadLine());

                 
                Console.Write("What is the name of your goal? ");
                n = Console.ReadLine();

                Console.Write("What is a short description of it? " );
                d= Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                points= Console.ReadLine();
                

                if(_type==1)
                {
                  
                   g= new Goal(n, d, points);
                   g.GetGoal();
        
                }

                if(_type==2)
                {
                  
                    g= new Goal(n,d,points);
                    g.GetGoal();
                }
                
                if(_type==3)
                {
                
                    Check C;

                    C= new Check(n,d,points);
                    
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    mB = Convert.ToInt32(Console.ReadLine());

                    C.GetGoal();

    
                }
                 
            }

            
            else if (userValue=="2")
            {
                
                List<ListGoals> lG= new List<ListGoals>();
                
                ListGoals l=new ListGoals(n,d,points);
                lG.Add(l);

                foreach (ListGoals lGoals in lG)
                {
                  
                    lGoals.GetGoal();
    
                }

                
            }

            else if (userValue=="3")
            {
                g=new Save(n,d,points);
                g.GetGoal();
            }

            else if (userValue=="4")
            {
                g=new Load(n,d,points);
                g.GetGoal();
            }

            else if (userValue=="5")
            {
                List<ListGoals> lG= new List<ListGoals>();

                ListGoals l=new ListGoals(n,d,points);
                lG.Add(l);

                foreach (ListGoals lGoals in lG)
                {
                    lGoals.GetGoal();
    
                }
                Console.Write("Which goal did you accomplish? ");
                cGoal = Convert.ToInt32(Console.ReadLine());

                if (cGoal==1)
                {
                    Console.WriteLine($"Congratulations! You have earned {points} points.");
                    Console.WriteLine($"You now have {points} points.");
                    

                    points+=pt;
                    Console.WriteLine();
                
                }
 
                
            }

            
        }
        while(userValue != "6");
 

    }
}
//To show creativity I added a message that appears at the end of each completed step