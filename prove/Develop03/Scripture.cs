using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;

        string[] verseArray = scriptureText.Split(' ');
        
        _words = new List<Word>();
        foreach (string word in verseArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void DisplayScripture()
    {
        foreach (Word word in _words)
        {
            word.displayWord();
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        while (_words[index].IsHidden())
        {
            index = random.Next(_words.Count);
        }
        _words[index].Hide();
    }

    public string GetScriptureString()
    {
        string scriptureString = _reference.GetReferenceString() + " ";
        foreach (Word word in _words)
        {
            scriptureString += word.GetWordString() + " ";
        }
        return scriptureString.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}