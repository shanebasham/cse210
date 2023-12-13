class Order
{
    public Customer Customer {get; }
    private List<Product> Products {get; }
    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public double CalculateTotalPrice()
    {
        double totalPrice = Products.Sum(product => product.CalculateProductPrice());
        return totalPrice + (Customer.IsInUSA() ? 5.0 : 35.0);
    }
    public string GetPackingLabel()
    {
        return string.Join("\n", Products.Select(product => $"{product.Name} (Product ID: {product.ProductId})"));
    }
    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.GetFormattedAddress()}";
    }
}