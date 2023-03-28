public class Checklist : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;
    private static object description;
    private static string name;
    private static readonly object points;

    public Checklist(string name, string description, int points, bool isComplete, int currentCount, int targetCount, int bonusPoints) : base()
    {
        _complete = false;
        _targetCount = 0;
        _currentCount = 0;
        _bonusPoints = 0;
        _name = name;
        _description = description;
        _points = points;
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public void GoalBonus()
    {
        Console.WriteLine("How many trials do you need for this Goal");
        _targetCount  = int.Parse(Console.ReadLine());
        Console.Write("How may bonus points should be awarded");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void DisplayGoal(int goalNumber)
    {
        string checkBox = "[]";
        if (_complete)
        checkBox = "[x]";
        Console.WriteLine($"{goalNumber}. {checkBox} {_name} ({_description}) >>> Progress {_currentCount}/{_targetCount}");
    }

     public override void SavedGoal()
       {
        _currentCount ++;
       if (_currentCount == _targetCount){
           _complete = true;
        }
}

        public override string DisplayGoalString()
    {
        string goal = $"ChecklistGoal|{_name}|{_description}|{_points}|{_complete}|{_currentCount}/{_targetCount}|{_bonusPoints}";
        return goal;
    }



}
