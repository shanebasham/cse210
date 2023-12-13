class Product
{
    public string Name {get; }
    public string ProductId {get; }
    private double Price {get; }
    private int Quantity {get; }
    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }
    public double CalculateProductPrice()
    {
        return Price * Quantity;
    }
}