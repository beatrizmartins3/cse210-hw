// C# program to illustrate encapsulation
using System;



class Program {

	
	static void Main(string[] args)
	{

		
		Scripture scrip=new Scripture();
		Reference obj = new Reference();

		
		scrip.txt="And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them. ";
    
		
		obj.Name = "1 Nephi";
		
		obj.Chapter = 3;

		obj.scripVerse=7;

		
		
		Console.WriteLine(obj.Name +" "+obj.scripVerse + " : "+obj.Chapter + " = " + scrip.txt );
		Console.WriteLine("Press enter:");
		
		while(true)
		{
			String user=Console.ReadLine();
			
			if(user=="quit")
			{
				break;
			}

			
			Console.WriteLine(GetRandomWords(scrip.txt));
		
		}

		

		static string GetRandomWords(string data)
		{
			
			Random random=new Random();
			var words = data.Split(' ');
            var start = random.Next(0, words.Length );
			var selectedWords = words.Skip(start);
			
		    return new string('-',words.Length);
			
		
			
		
        }
		
			
}
	
	
}

public class Reference {

	
	private String scripName;
	private int scripChapter;
	private int verse;

	
	public String Name
	{

		get { return scripName; }

		set { scripName = value; }
	}

		public int Chapter
	{

		get { return scripChapter; }

		set { scripChapter = value; }
	}

	public int scripVerse
	{
		get{return verse;}

		set {verse=value;}
	}
}

class Scripture{
	private String text;

	public String txt
	{
		get{return text;}
		set {text=value;}
	}
	
	
}

//To show creativity I choose the displayed scricpture
