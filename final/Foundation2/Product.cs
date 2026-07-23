using System;

class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product()
    {
        _name = "";
        _productId = "";
        _pricePerUnit = 0.0;
        _quantity = 0;
    }
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public double GetTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }
    public string GetProductInfo()
    {
        return $"Product Name: {_name}, Product ID: {_productId}, Price per Unit: {_pricePerUnit:C}, Quantity: {_quantity}";
    }
    public string GetProductPackingInfo()
    {
        return $"Product Name: {_name}, Product ID: {_productId}";
    }
}