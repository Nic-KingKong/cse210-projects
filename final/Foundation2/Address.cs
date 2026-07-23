using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _streetAddress = "";
        _city = "";
        _state = "";
        _country = "";
    }
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states" || _country.ToLower() == "united states of america";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}