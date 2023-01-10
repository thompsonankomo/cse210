using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage");
        string grade = Console.ReadLine();
        int percent= int.Parse(grade);

        string letter ="";


        if (percent >= 90)
        {
            letter ="A";
        }
        else if (percent >= 80)
        {
            letter="B";
        }
        else if (percent>=70)
        {
            letter="C";
        }
        else if (percent >=60)
        {
            letter ="D";
        }
        else if (percent>=50)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }
        Console.WriteLine($"You passed with a grade: {letter}");
        if(percent>=70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Try again next time");

        }

    }

}



    
