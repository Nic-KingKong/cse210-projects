using System;

class Event
{
    private string _eventName;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private string _eventAddress;

    public Event()
    {
        _eventName = "";
        _eventDescription = "";
        _eventDate = "";
        _eventTime = "";
        _eventAddress = "";
    }
    public Event(string eventName, string eventDescription, string eventDate, string eventTime, string eventAddress)
    {
        _eventName = eventName;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public string GetStandardDetails()
    {
        return $"Event Name: {_eventName}\nEvent Description: {_eventDescription}\nEvent Date: {_eventDate}\nEvent Time: {_eventTime}\nEvent Address: {_eventAddress}";
    }
    public string GetShortDescription(string EventType)
    {
        return $"Event Type: {EventType}\nEvent Name: {_eventName}\nEvent Date: {_eventDate}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
    public string GetEventName()
    {
        return _eventName;
    }
    public string GetEventDescription()
    {
        return _eventDescription;
    }
    public string GetEventDate()
    {
        return _eventDate;
    }
    public string GetEventTime()
    {
        return _eventTime;
    }
    public string GetEventAddress()
    {
        return _eventAddress;
    }
    public void SetEventName(string eventName)
    {
        _eventName = eventName;
    }
    public void SetEventDescription(string eventDescription)
    {
        _eventDescription = eventDescription;
    }
    public void SetEventDate(string eventDate)
    {
        _eventDate = eventDate;
    }
    public void SetEventTime(string eventTime)
    {
        _eventTime = eventTime;
    }
    public void SetEventAddress(string eventAddress)
    {
        _eventAddress = eventAddress;
    }
}