using System;

class Activity
{
    private string _date;
    private int _minutes;
    
    public Activity()
    {
        _date = "";
        _minutes = 0;
    }
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0.0;
    }
    public virtual double GetSpeed()
    {
        return 0.0;
    }
    public virtual double GetPace()
    {
        return 0.0;
    }
    public virtual string GetSummary()
    {
        return $"Date: {_date}, Minutes: {_minutes}, Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}