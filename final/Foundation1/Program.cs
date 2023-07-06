using System;

class Program
{
    static void Main(string[] args)
    {
        Video video= new Video();
        video._title="Recipe for brigadeiros";
        video._author="Ana Silva";
        video._length=900;

        Video video2= new Video();
        video2._title="Night Changes cover";
        video2._author="David Stone";
        video2._length=240;

        Video video3= new Video();
        video3._title="Skydiving challenge";
        video3._author="Siblings Wells ";
        video3._length=1800;

        Comment comment1 = new Comment();
        comment1._name = "Grace Vasquez";
        comment1._text="I love brigadeiro, your recipe is amazing";

        Comment comment2 = new Comment();
        comment2._name = "Jake Bing";
        comment2._text="I tried this recipe today and everyone in my job loved";

        Comment comment3 = new Comment();
        comment3._name = "Ellis Webber";
        comment3._text="I am trying new recipes for my grandchildren and this one is very easy";

        Comment comment4 = new Comment();
        comment4._name = "Caroline Fox";
        comment4._text="This song is amazing and you made it even better S2";

        Comment comment5 = new Comment();
        comment5._name = "Ally Moon";
        comment5._text="I honestly prefer the original version ";

        Comment comment6 = new Comment();
        comment6._name = "Carly Cooper";
        comment6._text="You are very talented, congratulations";

        Comment comment7 = new Comment();
        comment7._name = "Peter Geller";
        comment7._text="Very radical";

        Comment comment8 = new Comment();
        comment8._name = "Ethan Stevens";
        comment8._text="I will definitely do this";

        Comment comment9 = new Comment();
        comment9._name = "Luke Blake";
        comment9._text="I jumped once and I'll never jump again :), this is crazy";


        comment1._videos.Add(video);
        comment1._comments.Add(comment1);
        comment2._comments.Add(comment2);
        comment3._comments.Add(comment3);

        comment4._videos.Add(video2);
        comment4._comments.Add(comment3);
        comment5._comments.Add(comment4);
        comment6._comments.Add(comment5);

        comment7._videos.Add(video3);
        comment7._comments.Add(comment7);
        comment8._comments.Add(comment8);
        comment9._comments.Add(comment9);

        Console.WriteLine("-------------------------------------");

        Console.WriteLine();

        comment1.Display();
        Console.WriteLine();
        Console.WriteLine();
        comment1.GetComment();
        Console.WriteLine();
        comment2.GetComment();
        Console.WriteLine();
        comment3.GetComment();
       
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        comment4.Display();
        Console.WriteLine();
        Console.WriteLine();
        comment4.GetComment();
        Console.WriteLine();
        comment5.GetComment();
        Console.WriteLine();
        comment6.GetComment();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        comment7.Display();
        Console.WriteLine();
        Console.WriteLine();
        comment7.GetComment();
        Console.WriteLine();
        comment8.GetComment();
        Console.WriteLine();
        comment9.GetComment();
        
        Console.WriteLine("-------------------------------------");
    }
}