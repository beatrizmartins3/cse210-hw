using System;


class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity ");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Start relax activity ");
        Console.WriteLine("5. Quit ");
        Console.WriteLine("Select a choice from the menu:  ");
        String user=Console.ReadLine( );


        Activity activity;
        Activity act=new Activity("Well done!");

        if (user == "1" )
            {
                activity = new Breathing(" "," ");
            }
        else if (user == "2" )
            {
                activity = new Reflection(" "," ");
       
            }
        else if (user == "3" )
            {
                activity = new Listing(" "," ");
       
            }
        else if (user == "4" )
            {
                activity= new Relax(" "," ");
       
            }
        
        else if (user == "5" )
            {
                Console.WriteLine("Program finished");
                return;
            }

        else
            {
                Console.WriteLine("invalid option.");
                return;
            }
          
        activity.GetActivity();
        act.GetActivity();
 
    }
}

//To show creativity I created another activity called Relax