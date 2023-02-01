using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputNumber =-1;
        while (inputNumber !=0)
        {
            Console.Write("Please enter a number?(0 to quit)");
            string response = Console.ReadLine();
            inputNumber =int.Parse(response);

            if (inputNumber !=0)
            {
                numbers.Add(inputNumber);
            }
        }

    }

}
    int sum = 0;
        foreach(int number in numbers)
        {
            sum+=number;
        }
        Console.WriteLine($"The sum is:{sum}");

        float average =((float)sum)/ numbers.Count;
        Console.WriteLine($"The average is :{average}");

        int max = numbers[0];
        {
            max= numbers;
        }

        Console.WriteLine($"The max is:{max}");
   
