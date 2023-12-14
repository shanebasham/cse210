class Address
{
    private string Street {get; }
    private string City {get; }
    public Address(string street, string city)
    {
        Street = street;
        City = city;
    }
    public string GetFormattedAddress()
    {
        return $"{Street}, {City}";
    }
}