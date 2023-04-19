using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string input=Console.ReadLine();
        int number=int.Parse(input);

        string letter="" ;

        if (number>=90)
        {
            letter= "A";
        }  
        else if(number>=80)
        {
            letter="B";
        }
        else if (number>=70)
        {
            letter="C";
        }
        else if(number>=60)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }

        if (number>=60)
        {
            Console.WriteLine($"Your letter grade is {letter}. Congratulations, you passed.");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letter}. You can do it next time.");
        }
    }
    
}