class BaseActivity
{
    private string _activityName;
    private string _description;
    protected int _duration;

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
        Console.WriteLine("Get ready...");
    }

    public void RunCountDown(string message)
    {
        RunCountDown(message, _duration);
    }

    public void RunCountDown(string message, int duration)
    {
        int tempDuration = duration;

        // Console.WriteLine("Starting in:");
        // for (int i = 3; i > 0; i--)
        // {
        //     Console.Write($"{i} ");
        //     Thread.Sleep(1000);
        // }
        // Console.WriteLine();
        Console.WriteLine($"{message}: {tempDuration--, 2}");
        while (tempDuration > 0)
        {
            Console.WriteLine($"{tempDuration--, 2}");
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
    
    public void Spinner(int totalSeconds)
    {
        string animationString = "\\|/-";
        int index = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(totalSeconds);

        Console.CursorVisible = false;

        while (DateTime.Now < endTime)
            {
            
            int secondsLeft = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);
            if (secondsLeft < 0) secondsLeft = 0;

            char spinnerFrame = animationString[index % animationString.Length];
            index++;

            string output = $"{spinnerFrame}";
            Console.Write(output);

            Thread.Sleep(250);

            for (int i = 0; i < output.Length; i++)
                {
                    Console.Write("\b \b");
                }
            }

        Console.CursorVisible = true;
    }   
}