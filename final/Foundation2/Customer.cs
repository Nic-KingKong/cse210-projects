using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {
        _name = "";
        _address = new Address();
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
    public string GetName()
    {
        return _name;
    }
}