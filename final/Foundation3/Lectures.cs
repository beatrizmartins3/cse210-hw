using System;

public class Lecture: Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string eT, string descrip, string date, string time, string speaker, string cap) : base(eT, descrip, date, time)
    {
        _speaker=speaker;
        _capacity=cap;
    }

    

    public string GetLecture()
    {
        return $" The speaker is: {_speaker} \n Event capacity: {_capacity}";
    }


}