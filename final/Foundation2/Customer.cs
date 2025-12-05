class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool LiveInUsa()
    {
        return _address.IsUsa();
    }
    public string GetName()
    {
        return _name;
    }

    public string GetAddressText()
    {
        return _address.GetDisplayText();
    }
}