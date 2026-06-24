class BaseGoal
{
     private string _name;
        private string _description;
        private int _numberOfPoints;
        private bool _status;
        private string _goalType;

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    public void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }
    public void SetDescription()
    {
        Console.Write($"What is the description for {_name} goal? ");
        _description = Console.ReadLine();
    }
    public void SetNumberOfPoints()
    {
        Console.Write($"How many points is the {_name} goal worth? ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }
    public virtual string GetDisplayString()
    {
        string status = _status ? "[X]" : "[ ]";
        return $"{status} Goal: {_name}\nDescription: {_description}\nPoints: {_numberOfPoints}";
    }
    public int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }
}