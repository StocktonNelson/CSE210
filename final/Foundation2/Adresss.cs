public class Adresss
{
    private string _streetName;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;
    private bool _inAmerica;

    public Adresss(string streetName, string city, string state, string zipCode, string country, bool inAmerica)
    {
        _streetName = streetName;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
        _inAmerica = inAmerica;
    }
    public string GetFullAddress()
    {
        return $"{_streetName}\n{_city}, {_state} {_zipCode}\n{_country}";
    }

    public bool IsInAmerica()
    {
        return _inAmerica;
    }
}