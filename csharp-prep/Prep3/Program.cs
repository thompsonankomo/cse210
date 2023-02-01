using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        Console.WriteLine("What is your guess?");
        int magicNumber = int.Parse(Console.ReadLine());
        int guessNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int guessNumber = randomGenerator.Next(1,101);
    

        while (guessNumber != magicNumber)
        {
            Console.Write("what is your guess?");
            guessNumber= int.Parse(Console.ReadLine());

            if (magicNumber>guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if(magicNumber<guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }

        }

    }
}