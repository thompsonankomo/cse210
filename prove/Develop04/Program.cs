
class Program
{
    static void Main(string[] args)
    {
        int quit = 0;

        while (quit != 4){
            Console.Clear();
            Console.WriteLine("The Mindfullness App. Your way to relaxation, welcomes you!!");
            Console.WriteLine("Select an activity from the Menu.Select 4 to Quit Now!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            quit = int.Parse(Console.ReadLine());
            Console.Clear();

            if (quit == 1)
            {
                Breathing breathing = new Breathing();
                breathing.EntryMessage();
                breathing.RunActivity();
                breathing.EndMessage();
            }

            else if (quit == 2)
            {
                Listing listing = new Listing();
                listing.EntryMessage();
                listing.RunActivity();
                listing.EndMessage();
            } 

            else if (quit == 3)
            {
                Reflecting reflecting = new Reflecting();
                reflecting.EntryMessage();
                reflecting.RunActivity();
                reflecting.EndMessage();
            }

            else
            {
                Console.WriteLine("It was a pleasure hosting you. Seee you next time!");
                break;
            }
        }
    }
}