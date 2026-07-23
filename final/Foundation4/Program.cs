using System;

class Program
{
    static void Main(string[] args)
    {
        Activity runningActivity = new Running("2024-06-15", 30, 5.0); // 5 miles in 30 minutes
        Activity cyclingActivity = new Cycling("2024-06-16", 60, 15.0); // 15 mph for 60 minutes
        Activity swimmingActivity = new Swimming("2024-06-17", 45, 1.0); // 1 mile in 45 minutes

        List<Activity> activities = new List<Activity> { runningActivity, cyclingActivity, swimmingActivity };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}