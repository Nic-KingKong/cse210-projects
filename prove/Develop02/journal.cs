using System;

public class JournalEntry
{
    string _date;

    string _prompt;

    string _response;

    string[] _prompts = {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "What is something new you learned today?",
        "What is a challenge you faced today and how did you overcome it?",
        "What is something that made you smile today?"
    };

    public void CreateJournalEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        _prompt = _prompts[index];

        _date = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }
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