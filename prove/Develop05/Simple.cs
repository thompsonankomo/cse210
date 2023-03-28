using System;



public class SimpleGoals :Goal
{
public SimpleGoals(): base()
{
    _complete = false;
}

public SimpleGoals(string name, string description, int points, bool complete)
{
    _name = name;
    _description = description;
    _points = points;
    _complete = complete;
}
public overrride void SaveGoal()
{
    _complete = true;
}
    public override void DisplayGoal(int goalNumber)
    {
        base.DisplayGoal(goalNumber);
        string checkBox ="[]";
        if(_complete)
        checkBox = "[x]";
        Console.WriteLine($"{goalNumber},{checkBox}{_name},{_description}");

    }
    public override string DisplayGoalString()
    {
        return base.DisplayGoalString();
        string goal = $"SimpleGoal|{_name}|{_description}|{_points}|{_complete}";
        return goal;
    }
}