public class Customer
{
    // Store the customer's name and address
    private string _name;
    private Address _address;

    // Create a customer object
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    // Return the customer's name
    public string GetName()
    {
        return _name;
    }

    // Return the customer's address object
    public Address GetAddress()
    {
        return _address;
    }
}