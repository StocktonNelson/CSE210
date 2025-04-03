public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _adresss;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _adresss = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _adresss;
    }

    public virtual void GetStanderedInfo()
    {
        Console.WriteLine($"Title: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_adresss}");
    }

    public virtual void GetLongInfo()
    {
    }

    public virtual void GetShortInfo()
    {
    }
}