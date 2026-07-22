using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseActivity activity = new BaseActivity("Sample Activity", "This is a sample activity description.");
        // // activity.DisplayStartMessage();
        // // activity.RunCountDown("Breath in");
        // // activity.RunCountDown("Breath out");
        // // activity.DisplayEndMessage();
        // // activity.Spinner(5);
        // Breathing breathingActivity = new Breathing("This activity will help you relax by guiding you through breathing exercises.");
        // breathingActivity.Run();
        // Reflection reflectionActivity = new Reflection("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        // reflectionActivity.Run();
        // Listing listingActivity = new ListingActivity();
        // listingActivity.Run();
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    Breathing breathing = new Breathing("This activity will help you relax by guiding you through breathing exercises.");
                    breathing.Run();
                    break;

                case "2":
                    Reflection reflection = new Reflection("This activity will help you reflect on times in your life when you have shown strength and resilience.");
                    reflection.Run();
                    break;

                case "3":
                    Listing listing = new Listing("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.Run();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}