using System;

class Reference
{
    private string _bookName;

    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    public Reference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Reference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReferenceString()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_bookName} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}