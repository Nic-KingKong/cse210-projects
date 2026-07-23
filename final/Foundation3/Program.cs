using System;

class Program
{
    static void Main(string[] args)
    {
        Event lectureEvent = new Lecture("C# Basics", "An introduction to C#", "2024-06-15", "10:00 AM", "123 Main St", "John Doe", 100);
        Event receptionEvent = new Reception("Networking Reception", "An evening of networking", "2024-06-20", "6:00 PM", "456 Elm St", "networking@example.com");
        Event outdoorGatheringEvent = new OutdoorGathering("Picnic", "A fun day outdoors", "2024-06-25", "12:00 PM", "789 Oak St", "Expect sunny skies");
        Event genericEvent = new Event("Generic Event", "A generic event", "2024-06-30", "3:00 PM", "101 Pine St");

        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
    }
}