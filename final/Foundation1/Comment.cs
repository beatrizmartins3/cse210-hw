using System;

public class Comment
{
    public string _name;
    public string _text;

    public List<Video> _videos = new List<Video>();
    public List<Comment> _comments = new List<Comment>();

    public void GetComment()
    {
        foreach (Comment c in _comments)
        {
            Console.WriteLine($"{_name}: {_text}");
        }
    }
    

    
    
       
    public void Display()
    {
        
        foreach (Video v in _videos)
        {
           v.Display();
        }
        
    }
    
    
}