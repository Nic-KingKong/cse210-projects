class Journal
{
    List<JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine(entry.CreateFileSystemString());
            }
        }
    }
    public void ReadFromFile(string filename) 
    {

        string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {

            string[] parts = line.Split("#");

            string date = parts[0];

            string question = parts[1];

            string entryText = parts[2];

            JournalEntry entry = new JournalEntry(date, question, entryText);

            this.AddEntry(entry);

            }

    }
    
}