using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = NewAssignment("Multiplication","Thompson Nkomo");
        Console.WriteLine(a1.GetSummary());

        MathsAssignment a2 = NewMathsAssignment("Robert Moyo", "Fractions","6.5", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetSummaryList());

        WritingAssignment a3 = NewWritingAssignment("Thomas Sweswe","African History", "Causes of Zulu War");
        Console.Writeline(a3.GetSummary());
        Console.WriteLine(a3.GetSummaryList());
    }
}