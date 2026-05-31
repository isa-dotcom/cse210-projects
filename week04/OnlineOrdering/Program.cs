using System;

class Program
{
    static void Main(string[] args)
    {
        // First order (customer lives in the USA)

        Address usaAddress = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            usaAddress);

        Order order1 = new Order(customer1);

        // Add products to the first order
        order1.AddProduct(new Product(
            "Laptop",
            "P1001",
            800,
            1));

        order1.AddProduct(new Product(
            "Mouse",
            "P1002",
            25,
            2));

        // Second order (international customer)

        Address canadaAddress = new Address(
            "456 Maple Avenue",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer(
            "Emma Johnson",
            canadaAddress);

        Order order2 = new Order(customer2);

        // Add products to the second order
        order2.AddProduct(new Product(
            "Headphones",
            "P2001",
            120,
            1));

        order2.AddProduct(new Product(
            "Keyboard",
            "P2002",
            75,
            1));

        // Display information for order 1

        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n-------------------------\n");

        // Display information for order 2

        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order2.CalculateTotalCost()}");
    }
}