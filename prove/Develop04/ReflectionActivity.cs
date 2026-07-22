class Reflection : BaseActivity
{
    private readonly List<string> _prompts;
    private readonly List<string> _questions;
    private readonly Random _random;

    public Reflection(string description) : base("Reflection", description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you overcame a challenge."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did this experience change you?",
            "What did you learn about yourself?",
            "How did others see you in that moment?",
            "What did you learn about others?",
            "How can you apply this experience in the future?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What is your least favorite thing about this experience?",
            "What is the most important thing you learned from this experience?"
        };

        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} --- \n");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");

            // Calculate exact pause (e.g., 5-second reflection delay per question)
            int secondsLeft = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);
            int waitSeconds = Math.Min(5, secondsLeft);

            if (waitSeconds > 0)
            {
                Spinner(waitSeconds);
            }
            Console.WriteLine();
        }

        DisplayEndMessage();
    }
}