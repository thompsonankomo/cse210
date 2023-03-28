using System;


public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int  _points;
    protected bool _complete;
    

    public Goal( string name, string description, int points)
    {
     name =_name;
     description = _description;
     points = _points;
     _complete = false;

     _name = "";
     _description = "";
     _points = 0;
     _complete = false;

     
    }
    public void GoalName()
    {
        Console.WriteLine("What is the name of the Goal");
        _name =Console.ReadLine();
    }
    public void GoalDescription()
    {
        Console.WriteLine("Please describe your Goal");
        _description = Console.ReadLine();
    }
    public void GoalPoints()
    {
        Console.WriteLine("How many points is this goal worth scoring");
        _points = int.Parse (Console.ReadLine());
    }

    public int GetPoints()
    {
        return _points;
    }
    public  virtual void SaveGoal()
    {
        _complete = true;
    }
    public virtual void DisplayGoal(int goalNumber)
    {
         Console.WriteLine($"{goalNumber}. {_name} ({_description})");
    }
    public virtual void DisplaySimpleGoal(int goalNumber)
    {
        Console.WriteLine($"{goalNumber} , {_name} , {_description}");
    }
    public virtual string DisplayGoalString()
    {
        string goal = $"{_name}|{_description}| {_points}|{ _complete}";
        
        return goal;
    }
    
    






}