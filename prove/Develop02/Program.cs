using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry entry = new JournalEntry();
        entry.CreateJournalEntry();
        entry.Display();
        Console.WriteLine(entry.CreateFileSystemString());

        Journal journal = new Journal();
        journal.AddEntry(entry);
        journal.DisplayEntries();
    }
}