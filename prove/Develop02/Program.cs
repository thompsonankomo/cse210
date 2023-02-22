using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();
        myJournal.Run();
        
    }
}

class Journal
{
    private string File;
    private object myJournal;

    public void Run()
    {
        File = "Journal App";
        CreateJournalFile();
        DisplayJournalEntry();
        GetChoice();
        RunMenu();
    }

    private void GetChoice()
    {
        
    }

    private void DisplayJournalEntry()
    {
        Console.WriteLine ="Journal Contents Display";

    }

    private void CreateJournalFile()
    {
    Console.WriteLine($"Check if the file exists"{File.Exists(myJournal.txt)");
    if (!File.Exists("myJournal.txt"));
    {
        File.CreateText("myJournal.txt");
    }
    }
    private void ReadJournalContents()
    {
    string journal text = File.ReadAllText(myJournal.txt);
        Console.WriteLine("myJournal.txt");    
        }

    private string RunMenu()
    {
         string choice;
         {
        choice =GetChoice();
        switch(choice)
        {
            case "1":
            ReadJournalContents();
            break;
            case "2":
            SaveJournalContents();
            break;
            case "3":
            ReadJournalContents();
            case "4":
            WriteJournalContents();
            case "5":
            Quit();
        }
    }
       GetChoice();
    { 
        bool isChoiceValid = false;
        string choice = "";
        do
        {
        Console.WriteLine("Welcome to My Journal Entry");
        Console.WriteLine("\nPlease select one of the following choices");
        Console.WriteLine("\n > 1 - Read the Journal");
        Console.WriteLine("\n > 2 - Save the Journal");
        Console.WriteLine("\n > 3 - Load the Journal");
        Console.WriteLine("\n > 4 - Write to the Journal");
        Console.WriteLine("\n > 5 - Quit the Journal");
        Console.WriteLine("What would you want to do");
        
        string choice = Console.ReadLine();
        if (choice =="1" || choice == "2" || choice =="3" ||choice =="4" || choice == "5")
        {
          isChoiceValid = true;
        }
        else
        {
          Console.WriteLine($"{choice} is not a valid option. Choose numbers 1-5");
        }
        } while(!isChoiceValid);
        
        return choice;
    }
    
    }

    private void Quit()
    {
        
    }

    private void SaveJournalContents()
    {
        
    }

    private void WriteJournalContents()
    {
        
    }

    private void run()
    {
    
    }
}
}
