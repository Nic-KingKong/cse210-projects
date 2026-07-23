using System;
class OutdoorGathering: Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, string address)
        : base(title, description, date, time, address)
    {
        _weatherStatement = "";
    }
    public OutdoorGathering(string title, string description, string date, string time, string address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Statement: {_weatherStatement}";
    }
}