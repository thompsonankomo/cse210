using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[]args)
    {
    GoalsFiles Files = new GoalsFiles();
    List<Goal> goals = new List<Goal>();
    int points = 0;
    int quit = 0;
    int choice = 0;

    while (quit !=6)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest Game");
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu options");
        Console.WriteLine("1. Create a Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3.Save the Goals");
        Console.WriteLine("4. Load the Goal");
        Console.WriteLine("5. Displaythe Goal");
        Console.WriteLine("6. Quit the Game");
        Console.WriteLine("Select a viable option from the Menu");
        quit =int.Parse(Console.ReadLine());
    }
     Console.Clear();
      if (quit == 1)
      {
        Console.WriteLine("Select a viable Goal from the following");
        Console.WriteLine("1. Simple Goal ");
        Console.WriteLine("Eternal Goal");
        Console.WriteLine("Checklist Goal");
        choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
        Simple simple = new Simple();
        simple.GoalName();
        simple.GoalDescription();
        simple.GoalPoints();
        goals.Add(simple);
        }
        if(choice == 2)
        {
            Eternal eternal = new Eternal();
            eternal.GoalName();
            eternal.GoalDescription();
            eternal.GoalPoints();
            goals.Add(eternal);
        }
        if(choice == 3)
        {
            Checklist checklist = new Checklist();
            checklist.GoalName();
            checklist.GoalDescription();
            checklist.GoalPoints();
            checklist.GoalBonus();
            goals.Add(checklist);
        }
      }
      else if (quit == 2)
      {
        if (goals.Count == 0)
        {
            Console.WriteLine("Invalid, there isnt any goal created yet!");
        }
        else
        {
            int x = 0;
            foreach( Goal goal in goals)
            {
               x++;
               goal.DisplayGoal(x); 
            }
        }
      }
      else if(quit == 3)
      {
        File.loadFiles();
        goals = File.GetGoals();
        points = File.GetPoints();
      }
      else if(quit == 5)
      {
        File.GetSavedGoal(goals);
        points = File.GetPoints();
      }
      else
      {
        Console.WriteLine("Thanks for setting your worthwhile goals!");
      }
    }



    }





