using System;

class Reference
{
    private string _bookName;

    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    public void ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public void ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

}