using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1=new Address("Canal","2105","Salt Lake");
        Address a2=new Address("Broadway","5012","New York");
        Address a3=new Address("Main","2510","Los Angeles");
        

        Lecture l1= new Lecture ("Business","How to grow in business", "08/10/2023", "7:30","Taylor JR","70");
        l1.GetMessage();
        Console.WriteLine(l1.GetLecture());
        Console.WriteLine(a1.GetAddress());
        Console.WriteLine("--------------------------------------------------------------------");

        Reception r1=new Reception("Wedding", "Wedding of Brand and Angelina","09/07/2023","5","eventplanner@email.com");
        r1.GetMessage();
        Console.WriteLine(r1.GetReception());
        Console.WriteLine(a2.GetAddress());
        Console.WriteLine("--------------------------------------------------------------------");

        
        Outdoor o1= new Outdoor("Picnic", "A Frat Farewell Picnic","07/17/2023","6","During the week that the event takes place it will be summer, light rain is expected in the morning on the day of the event but does not affect the planning");
        o1.GetMessage();
        Console.WriteLine(o1.GetW());
        Console.WriteLine(a3.GetAddress());
        Console.WriteLine("--------------------------------------------------------------------");


    }
}

