using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private int _totalCost;
    private Customer _customer;
    List<Product> _products = new List<Product>();



    public Order(Customer customer, List<Product> products)
    {   
        _customer = customer;
        _products = products;
        foreach (Product item in products)
        {
            _totalCost += item.GetPricePerUnit() * item.GetQuantity();
        }

        //check if in america
        if (customer.GetAddress().IsInAmerica())
        {
            _totalCost += 5;
        }
        else
        {
            _totalCost += 35;
        }
    }
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {_customer.GetName()}\n";
        shippingLabel += $"Address:\n{_customer.GetAddress().GetFullAddress()}";
        return shippingLabel;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine("===== ORDER DETAILS =====");
        Console.WriteLine(GetShippingLabel());
        
        Console.WriteLine("\nProducts:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} (ID: {product.GetProductID()}) - ${product.GetPricePerUnit()} x {product.GetQuantity()} = ${product.CalculatePrice()}");
        }
        
        Console.WriteLine($"Total Order Cost: {_totalCost}");
        Console.WriteLine("=======================");
    }
}