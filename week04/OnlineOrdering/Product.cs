public class Product
{
    // Store information about each product
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Create a product object
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculate the total cost of this product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Return the product name
    public string GetName()
    {
        return _name;
    }

    // Return the product ID
    public string GetProductId()
    {
        return _productId;
    }
}