public class Product
{
    private string _name;
    private string _productID;
    private int _pricePerUnit;
    private int _quanty;
    
    public Product(string name, string productID, int pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quanty = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public int GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quanty;
    }

    public int CalculatePrice()
    {
        return _pricePerUnit * _quanty;
    }
}