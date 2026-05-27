using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry entry = new JournalEntry();
        entry.CreateJournalEntry();
       // entry.Display();
       // Console.WriteLine(entry.CreateFileSystemString());
        JournalEntry entry2 = new JournalEntry();
        entry2.CreateJournalEntry();


        Journal journal = new Journal();
        journal.AddEntry(entry);
        journal.AddEntry(entry2);


        journal.DisplayEntries();
        int response = 0;
        response = int.Parse(Console.ReadLine());

        switch(response)
        {
            case 1:
                JournalEntry newEntry = new JournalEntry();
                newEntry.CreateJournalEntry();
                journal.AddEntry(newEntry);
                break;
            case 2:
                journal.DisplayEntries();
                break;
        }
    }
}