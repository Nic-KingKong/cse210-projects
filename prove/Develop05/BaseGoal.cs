abstract class BaseGoal
{
    protected string _name;
    protected string _description;
    protected int _numberOfPoints;
    protected bool _status;
    protected string _goalType;

    public BaseGoal()
        : this("", "", 0, false)
    {
    }

    public BaseGoal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = "Goal";
    }

    protected void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    protected void SetDescription()
    {
        Console.Write($"What is the description for {_name} goal? ");
        _description = Console.ReadLine();
    }

    protected void SetNumberOfPoints()
    {
        Console.Write($"How many points is the {_name} goal worth? ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public virtual string GetDisplayString()
    {
        string status = _status ? "[X]" : "[ ]";
        return $"{status} Goal: {_name}\nDescription: {_description}\nPoints: {_numberOfPoints}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_goalType}:{_name},{_description},{_numberOfPoints},{_status}";
    }

    public bool IsComplete() => _status;
    public int GetPointsValue() => _numberOfPoints;

    public abstract bool MarkComplete();
    public abstract void CreateGoal();
    public abstract void RecordEvent();
    public virtual int GetPointsEarned() => 0;
}