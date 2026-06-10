class BaseActivity
{
    private string _activityName;
    private string _description;
    private int _duration;

    private DateTime _endTime;

    public BaseActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;

    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void RunCountDown(string message)
    {
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
        Console.WriteLine("Starting in:");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine($"{message}: {_duration--, 2}");
        while (_duration >= 0)
        {
            Console.WriteLine($"{_duration--, 2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} activity.");
        Thread.Sleep(3000);
    }
}