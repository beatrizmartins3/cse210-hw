using System;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers=new List<int>();

        int user=-1;
        while (user!=0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string answer=Console.ReadLine();
            user=int.Parse(answer);

            if (user!=0)
            {
                numbers.Add(user);
            }

        }
        
        int sum=0;
        foreach(int number in numbers)
        {
            sum+=number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average=((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest=numbers[0];
        foreach (int number in numbers)
        {
            if(number>largest)
            {
                largest=number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}