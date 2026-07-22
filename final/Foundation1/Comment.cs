using System;

class Comment
{
    private string _text;
    private string _name;

    public Comment()
    {
        _text = "";
        _name = "";
    }
    public Comment(string text, string name)
    {
        _text = text;
        _name = name;
    }

    public void SetText(string text)
    {
        _text = text;
    }
    public string GetText()
    {
        return _text;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
}