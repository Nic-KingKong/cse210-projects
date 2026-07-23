using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Widget", "W123", 10.0, 2);
        Product product2 = new Product("Gadget", "G456", 15.0, 1);
        Product product3 = new Product("Thingamajig", "T789", 5.0, 3);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotalPrice():C}");
        Console.WriteLine();

        Address address2 = new Address("456 Oak Ave", "Someplace", "ID", "USA");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Toy", "T123", 10.0, 2);
        Product product5 = new Product("Tool", "T456", 15.0, 1);
        Product product6 = new Product("Appliance", "A789", 5.0, 3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotalPrice():C}");
    }
}