using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry entry = new JournalEntry();
        entry.CreateJournalEntry();
        entry.Display();
    }
}