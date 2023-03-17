using System;
class system.string

class Program
{
    static void Main(string[] args)
    {
       Reference reference = new Reference("Galatians 5, 22");
       string verse ="But the fruit of the Spirit is love,joy, peace, longsuffering,gentleness,goodness, faith.";
       Scripture scripture = new Scripture(Reference, verse);
       var UserInput ="";

       while (true)
       {
        Console.WriteLine("Welcome to theScripture Memorizer App. We hope you will enjoy playing.  Press Enter to start. Press Quit to End..");
        Console.WriteLine(scripture.Display());
        Console.ReadLine();
       } 
       
       if (UserInput == "Play"|| "play")
       {
        play;
       }
       else
       {
        break;
       }
       scripture.HideWords();


    }
}