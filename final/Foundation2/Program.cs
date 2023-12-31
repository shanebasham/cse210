using System;
class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Laptop", "1", 555.55, 2);
        Product product2 = new Product("Mouse", "2", 8.50, 2);
        // Create addresses
        Address usaAddress = new Address("123 E Broadway Blvd.", "Pheonix", "AZ", "USA");
        Address internationalAddress = new Address("321 N 1st St", "London", "England", "United Kingdom");
        // Create customers
        Customer usaCustomer = new Customer("Jack Johnson", usaAddress);
        Customer internationalCustomer = new Customer("Susan Samuelson", internationalAddress);
        // Create order 1
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        // Create order 2
        Order order2 = new Order(internationalCustomer);
        order2.AddProduct(new Product("Book", "3", 15.25, 4));
        order2.AddProduct(new Product("Shoes", "4", 99.99, 2));
        // Display order information
        DisplayOrderInformation(order1);
        DisplayOrderInformation(order2);
    }
    // Display all
    static void DisplayOrderInformation(Order order)
    {
        Console.WriteLine($"Order for {order.Customer.Name}");
        Console.WriteLine($"\nPacking Label:\n{order.GetPackingLabel()}");
        Console.WriteLine($"\nShipping Label:\n{order.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice()}\n");
        Console.WriteLine("--------------------------------------------\n");
    }
}

// You have been hired to help a company with their product ordering system. They sell many products online to a variety of customers and need to produce packing labels, shipping labels, and compute final prices for billing.
// Program Specification
// Write a program that has classes for Product, Customer, Address, and Order. The responsibilities of these classes are as follows:
// Order
// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer
// Product
// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.
// Customer
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
// Address
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
// Other considerations
// Make sure that all member variables are private and getters, setters, and constructors are created as needed.
// Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. 
// Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.