using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Adresss usAddress = new Adresss("123 Main Street", "Seattle", "WA", "98101", "United States", true);
        Adresss internationalAddress = new Adresss("456 Queen Street", "Toronto", "Ontario", "M5V 2A8", "Canada", false);

        // Create customers
        Customer customer1 = new Customer("John Smith", usAddress);
        Customer customer2 = new Customer("Emily Johnson", internationalAddress);

        // Create products
        Product laptop = new Product("Laptop", "TECH001", 1200, 1);
        Product headphones = new Product("Wireless Headphones", "TECH002", 150, 1);
        Product mouse = new Product("Gaming Mouse", "TECH003", 80, 2);
        Product keyboard = new Product("Mechanical Keyboard", "TECH004", 120, 1);
        Product monitor = new Product("Monitor", "TECH005", 250, 1);
        Product chair = new Product("Office Chair", "FURN001", 180, 1);

        // Create first order with 3 products (US customer)
        List<Product> products1 = new List<Product>
        {
            laptop,
            headphones,
            mouse
        };
        Order order1 = new Order(customer1, products1);

        // Create second order with 3 products (International customer)
        List<Product> products2 = new List<Product>
        {
            keyboard,
            monitor,
            chair
        };
        Order order2 = new Order(customer2, products2);

        // Create list of all orders
        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };

        // Display all orders using foreach loop
        foreach (Order order in orders)
        {
            order.DisplayOrderDetails();
            Console.WriteLine(); // Add a blank line between orders
        }
    }
}