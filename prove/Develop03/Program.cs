using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi 3:7");
        string verse = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.";
        Scripture scripture = new Scripture(reference, verse);
        var input = "";
       while (true){
            Console.WriteLine("Welcome to the Scripture Memorizer app! Press <Enter> Type <Quit> to exit the game");
            Console.WriteLine(scripture.Display());
            input = Console.ReadLine();
            
            if (input == "Quit"|| input == "quit"){
                break;
            }
            if (scripture.IsCompletelyHidden()){
                break;
            }
            scripture.HideWords();

            

       }

    }
}
