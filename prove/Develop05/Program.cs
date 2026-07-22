using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseGoal goal = new BaseGoal();
        // goal.SetName();
        // goal.SetDescription();
        // goal.SetNumberOfPoints();
        // Console.WriteLine(goal.GetDisplayString());
        // goal.MarkComplete();
        // Console.WriteLine(goal.GetDisplayString());

        // SimpleGoal simpleGoal = new SimpleGoal();
        // simpleGoal.CreateGoal();
        // Console.WriteLine(simpleGoal.GetDisplayString());
        // simpleGoal.RecordEvent();
        // Console.WriteLine(simpleGoal.GetDisplayString());
        GoalManager goalManager = new GoalManager();
        goalManager.StartMenu();
    }
}

class GoalManager
{
    private readonly List<BaseGoal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<BaseGoal>();
        _score = 0;
    }

    public void StartMenu()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine();
            DisplayPoints();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalInfo();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void ListGoalInfo()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
            Console.WriteLine();
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points, false));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points, false));
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;

            default:
                Console.WriteLine("Invalid goal type selected.");
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals available to record.");
            return;
        }

        Console.WriteLine("The goals are:");
        ListGoals();
        Console.Write("Which goal did you accomplish? ");

        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            BaseGoal selectedGoal = _goals[goalIndex - 1];

            if (selectedGoal.IsComplete())
            {
                Console.WriteLine("This goal is already complete!");
                return;
            }

            selectedGoal.RecordEvent();
            int pointsEarned = selectedGoal.GetPointsEarned();
            _score += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using StreamWriter outputFile = new StreamWriter(filename);
        outputFile.WriteLine(_score);

        foreach (BaseGoal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(':');
            string goalType = parts[0];
            string[] details = parts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                bool isComplete = bool.Parse(details[3]);

                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                bool isComplete = bool.Parse(details[3]);

                _goals.Add(new EternalGoal(name, description, points, isComplete));
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                int target = int.Parse(details[3]);
                int bonus = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);
                bool isComplete = bool.Parse(details[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                for (int c = 0; c < amountCompleted; c++)
                {
                    goal.MarkComplete();
                }
                if (isComplete)
                {
                    goal.MarkComplete();
                }
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}