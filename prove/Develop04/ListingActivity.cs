using System;

class Listing : BaseActivity
{
    private readonly List<string> _prompts;
    private readonly Random _random;
    private int _count;

    public Listing(string description) : base("Listing", description)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Spirit this month?",
            "Who are some of your personal heroes?"
        };

        _random = new Random();
        _count = 0;
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Keep asking for input until the duration has elapsed
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            
            // Console.ReadLine() is a blocking call, so if the user types something 
            // after the time expires, we check time before adding it to the count.
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                userItems.Add(input);
            }
        }

        return userItems;
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        Console.WriteLine();

        // Collect inputs from the user
        _count = 0;
        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"You listed {_count} items!\n");

        DisplayEndMessage();
    }
}