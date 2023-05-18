using System;
using System.Collections.Generic;
using System.IO;

class Entry{
    public string thePrompt;
    public string answer;
    public DateTime date;

    public Entry(string thePrompt, string answer,DateTime date){
        this.thePrompt=thePrompt;
        this.answer=answer;
        this.date=date;
    }

    public override string ToString(){
        return "("+ date.ToString() +")" + " " +thePrompt+ " "+"=" + answer;
    }

}

class Journal{
    public List<Entry>entries;
    public Journal(){
        entries=new List<Entry> ();
    }

    public void AddEntry(string thePrompt,string answer,DateTime date){
        entries.Add(new Entry(thePrompt,answer,date));
    }

    public void DisplayEntries(){
        foreach(Entry entry in entries){
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename){
        using (StreamWriter strW=new StreamWriter(filename)){
            foreach(Entry entry in entries){
                strW.WriteLine(entry.thePrompt);
                strW.WriteLine(entry.answer);
                strW.WriteLine(entry.date);
            }
        }

    }

    public void LoadFromFile(string filename){
        using (StreamReader strR=new StreamReader(filename)){
            while(!strR.EndOfStream){
                string thePrompt=strR.ReadLine();
                string answer=strR.ReadLine();
                DateTime date= DateTime.Parse(strR.ReadLine());
                entries.Add(new Entry(thePrompt,answer,date));
            }
        }
    }
}



class Program {
     private static readonly string[] prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I did today?",
        "What is something that take me out of the comfort zone I did today?",
        "What is something I am grateful for today?"
    };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
    private static Journal journal = new Journal();
    private static Random random = new Random();

    static void Main(string[] args)
    {
        
        bool quit = false;
        while (!quit) {
            Console.WriteLine("Welcome to your journal!");
            Console.WriteLine("1. Add ");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What you would like to do? ");
            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input) {
                case "1":
                    string thePrompt = GetRandomPrompt();
                    Console.WriteLine(thePrompt);
                    Console.Write("= ");
                    string answer = Console.ReadLine();
                    journal.AddEntry(thePrompt, answer, DateTime.Now);
                    Console.WriteLine("Entry added.");
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    Console.WriteLine("Entry saved.");
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    Console.WriteLine("Entry loaded from file.");
                    break;

                case "5":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

//Classes: Entry|Journal|Program
//To show creativity I added more questions to the program which will show the question randomly