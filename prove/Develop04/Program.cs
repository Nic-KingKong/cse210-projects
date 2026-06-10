using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity activity = new BaseActivity("Sample Activity", "This is a sample activity description.");
        activity.DisplayStartMessage();
        activity.RunCountDown("Breath in");
        activity.RunCountDown("Breath out");
        activity.DisplayEndMessage();
    }
}