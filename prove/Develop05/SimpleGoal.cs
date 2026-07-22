class SimpleGoal : BaseGoal
{
    private int _pointsEarned;

    public SimpleGoal() : base()
    {
        _goalType = "SimpleGoal";
    }

    public SimpleGoal(string name, string description, int points, bool status)
        : base(name, description, points, status)
    {
        _goalType = "SimpleGoal";
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override void RecordEvent()
    {
        bool isComplete = MarkComplete();
        Console.WriteLine($"Goal status updated. Complete: {isComplete}");
    }

    public override bool MarkComplete()
    {
        _pointsEarned = 0;
        if (!_status)
        {
            _status = true;
            _pointsEarned = _numberOfPoints;
        }
        return _status;
    }

    public override int GetPointsEarned() => _pointsEarned;

    public override string GetDisplayString()
    {
        string status = _status ? "[X]" : "[ ]";
        return $"{status} Simple Goal: {_name}\nDescription: {_description}\nPoints: {_numberOfPoints}";
    }
}