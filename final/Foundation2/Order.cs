using System;

class Order
{
    private Customer _customer;
    private List<Product> _products;
    public Order()
    {
        _customer = new Customer();
        _products = new List<Product>();
    }
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double CalculateTotalPrice()
    {
        double total = 0.0;
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }
        if (_customer.IsInUSA())
        {
            total += 5.00;
        }
        else
        {
            total += 35.00;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductPackingInfo()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetFullAddress()}";
    }
    
}