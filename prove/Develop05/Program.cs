using System;

class Program
{
    static void Main(string[] args)
    {
        BaseGoal goal = new BaseGoal();
        goal.SetName();
        goal.SetDescription();
        goal.SetNumberOfPoints();
        Console.WriteLine(goal.GetDisplayString());
        goal.MarkComplete();
        Console.WriteLine(goal.GetDisplayString());
    }
}