using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address)
        : base(title, description, date, time, address)
    {
        _speaker = "";
        _capacity = 0;
    }
    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}