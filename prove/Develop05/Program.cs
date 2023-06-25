using System;

class Program
{
    static void Main(string[] args)
    {
        string userValue;
        int points=0;
        Goal g;
        string n=" ";
        string d="";
        string pt="";
        int b;
        int mB;
        
        
         
        do
        {
            Console.WriteLine($"You have {points} points. \n ");
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
                   //int pt=Convert.ToInt32(Console.ReadLine());
                d= Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                pt= Console.ReadLine();

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                mB = Convert.ToInt32(Console.ReadLine());





                if(_type==1)
                {
                    //Console.Write(nG);
                    //Console.ReadLine();

                    //Console.Write(dG);
                    //Console.ReadLine();

                    //Console.Write(pnt);
                   // Console.ReadLine();
                    //Convert.ToInt32(Console.ReadLine());

                    //g= new Goal(nG,dG,pnt);
                   // g.GetGoal();
                  

                   g= new Goal(n, d, pt);
                   g.GetGoal();
        
                }

                if(_type==2)
                {
                    //Console.Write(nG);
                    //Console.ReadLine();

                    //Console.Write(dG);
                    //Console.ReadLine();

                    //Console.Write(pnt);
                    //Console.ReadLine();
                    //Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine("What is the name of your goal? ");
                    //n = Console.ReadLine();

                    //Console.WriteLine(dG);
                    //string d= Console.ReadLine();

                    //Console.WriteLine(pnt);
                    //int pt=Convert.ToInt32(Console.ReadLine());
                    //string pt= Console.ReadLine();



                    
                    g= new Goal(n,d,pt);
                    g.GetGoal();
                }
                
                if(_type==3)
                {
                    //Console.Write(nG);
                    //Console.ReadLine();

                    //Console.Write(dG);
                    //Console.ReadLine();

                    //Console.Write(pnt);
                    //Console.ReadLine();
                    //Convert.ToInt32(Console.ReadLine());

                    //Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    //int b = Convert.ToInt32(Console.ReadLine());

                    //Console.Write("What is the bonus for accomplishing it that many times? ");
                    //int mB = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine("What is the name of your goal? ");
                    //string n = Console.ReadLine();

                    //Console.WriteLine(dG);
                    //string d= Console.ReadLine();

                    //Console.WriteLine(pnt);
                    //int pt=Convert.ToInt32(Console.ReadLine());
                    //string pt= Console.ReadLine();



                    g= new Check(n,d,pt,b,mB);
                    g.GetGoal();



    
                }
                 
                
                //g=new Goal (0," "," ",0,0,0);
                //Console.WriteLine(iN);
                //Console.ReadLine();

                //Console.WriteLine(iA);
                //int.Parse(Console.ReadLine());
                //Console.ReadLine();

                //Console.WriteLine(sI);
                //Console.ReadLine();

                
                //g.GetGoal();
            }

            
            else if (userValue=="2")
            {
                //g=new ListGoals(0,0," "," ",0,0,0);
                
                g= new ListGoals(n,d,pt);
                g.GetGoal();
                
            }

            else if (userValue=="3")
            {
                g=new Save(n,d,pt);
                g.GetGoal();
            }

            else if (userValue=="4")
            {
                g=new Load(n,d,pt);
                g.GetGoal();
            }

          
            
        }
        while(userValue != "6");
        

       
        
        


    }
}