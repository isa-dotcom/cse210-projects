using System.Collections.Generic;

public class Order
{
    // Store all products for this order
    private List<Product> _products;

    // Store the customer who placed the order
    private Customer _customer;

    // Create an order and start with an empty product list
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate products total + shipping cost
    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // USA shipping is $5, international shipping is $35
        total += _customer.LivesInUSA() ? 5 : 35;

        return total;
    }

    // Create the packing label with product names and IDs
    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return label;
    }

    // Create the shipping label with customer info
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}