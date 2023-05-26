using System;

namespace MyApplication
{
  class Scripture
  {
    private string _scripture;
    private string _reference;
    private int chapter;
    private int verse;

    // Create a class constructor with multiple parameters
    public Scripture(string scripReference, int scripChapter, int scripVerse, string scripText)
    {
      _scripture = scripText;
      _reference = scripReference;
      chapter = scripChapter;
      verse=scripVerse;

      _scripture="If ye love me, keep my commandments";
      _reference="John";
      chapter=14;
      verse=15;
    }

    static void Main(string[] args)
    {
      Scripture text = new Scripture(" ",0,0," ");
      Console.WriteLine(text._reference + " " + text.chapter + " : " + text.verse + " = " + text._scripture);

      
    }
  }
}