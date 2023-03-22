using System;

public class Activity{
    protected string _name;
    protected int _duration;
    protected string _description;
    protected DateTime _endTime;

    public Activity()
    {}
   
    public void GetSpinner(){
        List<string> animationStrings = new List<string>();

        animationStrings.Add("-");
        animationStrings.Add("-");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        while (DateTime.Now < endTime){
            foreach (string s in animationStrings)
            {
            Console.Write(s);
            Thread.Sleep(750);
            Console.Write("\b \b");
            }   
        }
    }

    public void GetDuration(int duration){
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(duration);
    }

    public void EntryMessage()
   {    Console.Write($"Loading {_name} activity...");
        GetSpinner();
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine("");

        Console.WriteLine($"{_description}");
        Console.WriteLine("");

        Console.WriteLine("How long would you want the activity to last (in seconds)");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Loading...");
        GetSpinner();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        Thread.Sleep(3000);
        Console.Clear();
   }

   public void EndMessage()
   {
    Console.WriteLine($" {_name} activity has been completed!");
    Console.WriteLine($"See you again next time for fun!");
   }




}