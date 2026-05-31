public class Address
{
    // Store the customer's address information
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Create an address object with all required fields
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Check if the customer lives in the USA
    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // Return the complete address as one formatted string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}