class SimpleGoal : BaseGoal
{
    private int _points;

    public SimpleGoal() : base()
    {
       
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }
    public override void RecordEvent()
    {
        int pointsEarned = MarkComplete();
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points for completing the goal.");
    }
}