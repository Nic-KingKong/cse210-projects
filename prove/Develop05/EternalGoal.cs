class EternalGoal : BaseGoal
{
    public EternalGoal() : base()
    {
        _goalType = "EternalGoal";
    }

    public EternalGoal(string name, string description, int points, bool status)
        : base(name, description, points, status)
    {
        _goalType = "EternalGoal";
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
        
        return false;
    }

    public override int GetPointsEarned() => _numberOfPoints;
}