using System;

class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int minutes, double laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; // Distance in kilometers (assuming each lap is 50 meters)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; // Speed in kilometers per hour
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); // Pace in minutes per kilometer
    }
}