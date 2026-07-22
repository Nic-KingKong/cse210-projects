class ChecklistGoal : BaseGoal
{
    private int _target;
    private int _bonus;
    private int _amountCompleted;

    public ChecklistGoal() : base()
    {
        _goalType = "ChecklistGoal";
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points, false)
    {
        _goalType = "ChecklistGoal";
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent()
    {
        bool isComplete = MarkComplete();
        Console.WriteLine($"Goal status updated. Complete: {isComplete}");
    }

    public override bool MarkComplete()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _status = true;
        }
        return _status;
    }

    public override int GetPointsEarned()
    {
        return _status ? _numberOfPoints + _bonus : _numberOfPoints;
    }

    public override string GetDisplayString()
    {
        string status = _status ? "[X]" : "[ ]";
        return $"{status} Checklist Goal: {_name}\nDescription: {_description}\nPoints: {_numberOfPoints}\nCompleted: {_amountCompleted}/{_target}\nBonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}:{_name},{_description},{_numberOfPoints},{_target},{_bonus},{_amountCompleted},{_status}";
    }
}