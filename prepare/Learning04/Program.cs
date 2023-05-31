using System;

namespace library_demo
{
   class Program
   {
    static void Main(string[] args)
    {
        Assignment assignment1=new Assignment("Samuel Bennett"," Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment ma=new MathAssignment("7.3","8-19","Roberto Rodriguez ","Fractions");
        Console.WriteLine(ma.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());

        WritingAssignment wa=new WritingAssignment ("The Causes of World War II","Mary Waters", "European History");
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());

    }
   } 
}
