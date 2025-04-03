public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address){
        _weather = weather;
    }

    public string GetWeather(){
        return _weather;
    }

    public override void GetStanderedInfo(){
        base.GetStanderedInfo();
    }

    public override void GetLongInfo(){
        Console.WriteLine($"Title: {base.GetTitle()} \nDescription: {base.GetDescription()} \nDate: {base.GetDate()} \nTime: {base.GetTime()} \nAddress: {base.GetAddress()} \nEvent: Outdoor \nWeather: {_weather}");
    }

    public override void GetShortInfo(){
        Console.WriteLine($"Event: Outdoor \nTitle: {base.GetTitle()} \nDate: {base.GetDate()}");
    }
}