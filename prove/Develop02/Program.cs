using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display the new Entry");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry._prompt = GetRandomPrompt();
                Console.WriteLine(newEntry._prompt);
                newEntry._response = Console.ReadLine();
                Console.WriteLine("Where are you right now?");
                newEntry._place = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                journal._entries.Add(newEntry);
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.Write("New Entry please!: ");
                journal._filename = Console.ReadLine();
                journal.LoadFile();
            }
            else if (choice == 4)
            {
                Console.Write("New Entry Please ");
                journal._filename = Console.ReadLine();
                journal.SaveFile();
            }
            else if (choice == 5)
            {
                break;
            }
        }
        static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "What i something youdid differently today",
            "How did you see the hand of the Lord today?",
            "What was your main highlight in your scripture study today",
            "Describe a time when you felt the presence of the Holy Ghost",
            "Describe a time you served someone for free",
            "How did you feel at the Sacrament Meeting this past Sunday",
            "What does the Book of Mormon  teach about Jesus Christ"
            

        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    }


    }