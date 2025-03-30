public class Customer
{
    private string _name;

    private Adresss _address;

    public Customer(string name, Adresss address){
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }

    public Adresss GetAddress()
    {
        return _address;
    }
}