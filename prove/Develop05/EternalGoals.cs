using System;

public class EternalGoals : Goal
{
    public EternalGoals(): base()
    {
        _complete = false;
    }

    public EternalGoals(string name, string description, int points, bool complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public virtual override SaveGoal()
    {
        return SaveGoal;
    }
    public override string DisplayGoalString()
    {
      string goal =$"EternalGoal|{_name}|{_description}|{_points}|{_complete}";
      return goal;
    }
}

