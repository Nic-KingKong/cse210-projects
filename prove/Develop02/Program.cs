using System;

class Program
{
    public void menuDisplay_6()
{
    Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.WriteLine("What would you like to do? ");
}
    static void Main(string[] args)
    {
        // JournalEntry entry = new JournalEntry();
        // entry.CreateJournalEntry();
        // entry.Display();
        // Console.WriteLine(entry.CreateFileSystemString());
        // JournalEntry entry2 = new JournalEntry();
        // entry2.CreateJournalEntry();


         Journal journal = new Journal();
        // journal.AddEntry(entry);
        // journal.AddEntry(entry2);


        // journal.DisplayEntries();
        Console.WriteLine("Welcome to the Journal Program!");
        Program menu = new Program();
        menu.menuDisplay_6();

        int response = 0;
        response = int.Parse(Console.ReadLine());
        while(response != 5)
        {
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
                case 3:
                    Console.WriteLine("What is the filename of the journal you want to load? ");
                    string loadFileName = Console.ReadLine();
                    journal.ReadFromFile(loadFileName);
                    break;
                case 4:
                    Console.WriteLine("What is the filename of the journal you want to save? ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;  
                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }
            menu.menuDisplay_6();
            response = int.Parse(Console.ReadLine());
        }
    }
}