using System;

public class JournalEntry
{
    string _date;

    string _prompt;

    string _response;

    public JournalEntry()
    {
        
    }

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"{_date}#{_prompt}#{_response}");
    }

    public void EntryToString()
    {
        
    }

    public void CreateEntryWithPrompt()
    {
    
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        
    }

    public void CreateEntryWithData(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

}